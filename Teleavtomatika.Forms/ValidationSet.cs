// Copyrigth (c) Teleavtomatika Ltd. All rights reserved.
// Author: Fomin Dmitry
// Date: 2014/01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teleavtomatika.Forms
{
    /// <summary>
    /// Represents a set of ValidationRule for a control
    /// </summary>
    class ValidationSet
    {
        #region Varaibles

        // list of rules
        List<ValidationRule> validationRules = new List<ValidationRule>();

        #endregion

        #region Constructor

        public ValidationSet(FormValidator formValidator, Control control)
        {
            FormValidator = formValidator;
            Control = control;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Control which is bound to the set
        /// </summary>
        public Control Control { get; private set; }

        /// <summary>
        /// Form validator of this set
        /// </summary>
        public FormValidator FormValidator { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Validates control for all rule and set error if it occurs.
        /// Returns true if all validation passed without errors.
        /// </summary>
        public bool Check()
        {
            var errors = validationRules.Where(r => r.ValidationType == ValidationType.Required && !r.Check());
            var exclamations = validationRules.Where(r => r.ValidationType == ValidationType.Optional && !r.Check());
            bool hasError = errors.Count() > 0;
            bool hasExclamation = exclamations.Count() > 0;

            // set new errors
            if (hasError)
            {
                // errors have higher priority
                string text = errors.Aggregate("", (s, e) => s + (s != "" ? "\n – " : " – ") + e.Message);
                if (FormValidator.errorProvider.GetError(Control) != text)
                    FormValidator.errorProvider.SetError(Control, text);
            }
            else
            {
                // reset error
                if (FormValidator.errorProvider.GetError(Control) != "")
                    FormValidator.errorProvider.SetError(Control, "");

                if (hasExclamation)
                {
                    // exclamation has lower priority
                    string text = exclamations.Aggregate("", (s, e) => s + (s != "" ? "\n – " : " – ") + e.Message);
                    if (FormValidator.exclamationProvider.GetError(Control) != text)
                        FormValidator.exclamationProvider.SetError(Control, text);
                }
                else
                {
                    // reset exclamation
                    if (FormValidator.exclamationProvider.GetError(Control) != "")
                        FormValidator.exclamationProvider.SetError(Control, "");
                }
            }

            return !hasError;
        }

        /// <summary>
        /// Adds new rule to list
        /// </summary>
        public void AddRule(ValidationRule validationRule)
        {
            FormValidator.CheckThread();
            validationRules.Add(validationRule);
        }

        #endregion
    }
}
