// Copyrigth (c) Teleavtomatika Ltd. All rights reserved.
// Author: Fomin Dmitry
// Date: 2014/01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Windows.Forms;
using System.Threading;

namespace Teleavtomatika.Forms
{
    /// <summary>
    /// Implements form validation functionality.
    /// </summary>
    class FormValidator : IDisposable
    {
        #region Static functionality

        // thread safe dictionary of form validators
        private static ConcurrentDictionary<Form, FormValidator> validators =
            new ConcurrentDictionary<Form, FormValidator>();

        /// <summary>
        /// Return validator for form if it exists or create it and return
        /// </summary>
        public static FormValidator GetValidator(Form form)
        {
            if (validators.ContainsKey(form))
                return validators[form];
            else
                return new FormValidator(form);
        }

        #endregion

        #region Instance varaibles

        // form that bound to this validator
        private Form form;

        // form error provider
        internal ErrorProvider errorProvider;

        // form exclamation provider
        internal ErrorProvider exclamationProvider;

        // list of rules for this validator
        private List<ValidationSet> rules = new List<ValidationSet>();

        // validation timer
        private System.Windows.Forms.Timer timer;

        // thread that bound to this validator
        private Thread thread;

        #endregion

        #region Events

        /// <summary>
        /// Event delegate
        /// </summary>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public delegate void ValidationCompletedEventHandler(bool result);

        /// <summary>
        /// Raises when validation completed.
        /// </summary>
        public event ValidationCompletedEventHandler ValidationCompleted;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FormValidator"/> class. 
        /// And bind this instance to corresponding form;
        /// </summary>
        public FormValidator(Form form)
        {
            // check if validator is already exists for this form;
            if (validators.ContainsKey(form))
                throw new InvalidOperationException("This form already has a validator, you can't create another one.");

            // construct providers
            errorProvider = new ErrorProvider(form)
                {
                    BlinkStyle = ErrorBlinkStyle.NeverBlink,
                    Icon = Teleavtomatika_Form_Validation.Properties.Resources.RedCircle
                };

            exclamationProvider = new ErrorProvider(form)
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink,
                Icon = Teleavtomatika_Form_Validation.Properties.Resources.YellowCircle
            };

            // bind to form and add to validators dictionary
            this.form = form;
            if (!validators.TryAdd(form, this))
                throw new InvalidOperationException("Can't create FormValidator.");

            // create validation timer and start it
            timer = new System.Windows.Forms.Timer() { Interval = 100, Enabled = true };
            timer.Tick += new EventHandler(timer_Tick);

            // bind object disposing to form disposed event
            form.Disposed += (s, e) => Dispose();

            // remember created thread
            thread = Thread.CurrentThread;
        }

        #endregion

        #region Validation

        // timer procedure
        void timer_Tick(object sender, EventArgs e)
        {
            ValidateAll();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add new validation rule for control.
        /// </summary>
        internal void AddValidationSet(ValidationSet validationSet)
        {
            CheckThread();

            // check if corresponding control already has validation rule
            var rule = rules.Where(r => r.Control == validationSet.Control).FirstOrDefault();
            if (rule != null)
                throw new InvalidOperationException(string.Format("Control {0} already have set of validations rule. You can create only one validation set for each control.", validationSet.Control));

            rules.Add(validationSet);
        }

        /// <summary>
        /// Returns validation set by control or null if it is not exist.
        /// </summary>
        /// <param name="control">Control to find validation set for</param>
        internal ValidationSet GetValidationSet(Control control)
        {
            return rules.Where(r => r.Control == control).FirstOrDefault();
        }

        /// <summary>
        /// Checks all rules and return true if all rules marked as required returns true
        /// </summary>
        public bool ValidateAll()
        {
            CheckThread();

            var result = true;

            foreach (var rule in rules)
            {
                result = rule.Check() && result;
            }

            if (ValidationCompleted != null)
                ValidationCompleted(result);

            return result;
        }

        #endregion

        #region Helpers

        public void CheckThread()
        {
            if (thread != Thread.CurrentThread)
                throw new Exception("This method must be invoked from the same thread from wich it was created.");
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            CheckThread();

            // dispose timer
            if (timer != null)
            {
                timer.Enabled = false;
                timer.Dispose();
                timer = null;
            }

            // clear rules
            if (rules != null)
            {
                rules.Clear();
                rules = null;
            }

            // remove validator
            FormValidator validator = null;
            validators.TryRemove(form, out validator);
        }

        #endregion
    }
}
