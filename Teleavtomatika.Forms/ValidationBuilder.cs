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
    /// Control validation builder endpoint.
    /// </summary>
    /// <typeparam name="T">DataType of control</typeparam>
    public class ValidationBuilder<T>
        where T : Control
    {
        #region Varaibles

        // control for which this building validation
        Control control;

        // formvalidator 
        FormValidator formValidator;

        // validation set
        ValidationSet validationSet;

        // default message for validation
        string defaultMessage = "Это поле является обязательным для заполнения.";

        #endregion

        #region Constructor

        internal ValidationBuilder(Control control)
        {
            var form = control.TopLevelControl;
            if (!(form is Form))
                throw new InvalidOperationException("Control must be on form");

            this.control = control;
            formValidator = FormValidator.GetValidator((Form)form);
            validationSet = formValidator.GetValidationSet(control);
            if (validationSet == null)
            {
                validationSet = new ValidationSet(formValidator, control);
                formValidator.AddValidationSet(validationSet);
            }
        }

        #endregion

        #region Methods

        #region IsNotNullOrEmpty

        /// <summary>
        /// Validates, that expression returns not null or empty string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        /// <param name="validationType">Validation type</param>
        public ValidationBuilder<T> IsNotNullOrEmpty(Func<T, string> expression, string message, ValidationType validationType)
        {
            validationSet.AddRule(new ValidationRule(() => !string.IsNullOrEmpty(expression((T)control)), message, validationType));
            return this;
        }

        /// <summary>
        /// Validates, that expression returns not null or empty string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        public ValidationBuilder<T> IsNotNullOrEmpty(Func<T, string> expression, string message)
        {
            return IsNotNullOrEmpty(expression, message, ValidationType.Required);
        }

        /// <summary>
        /// Validates, that expression returns not null or empty string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        public ValidationBuilder<T> IsNotNullOrEmpty(Func<T, string> expression)
        {
            return IsNotNullOrEmpty(expression, defaultMessage, ValidationType.Required);
        }

        /// <summary>
        /// Validates, that controls property 'Text' returns not null or empty string value.
        /// </summary>
        public ValidationBuilder<T> IsNotNullOrEmpty()
        {
            return IsNotNullOrEmpty(c => c.Text, defaultMessage, ValidationType.Required);
        }

        #endregion

        #region IsNotNullOrWhitespace

        /// <summary>
        /// Validates, that expression returns not null or whitespace string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        /// <param name="validationType">Validation type</param>
        public ValidationBuilder<T> IsNotNullOrWhitespace(Func<T, string> expression, string message, ValidationType validationType)
        {
            validationSet.AddRule(new ValidationRule(() => !string.IsNullOrWhiteSpace(expression((T)control)), message, validationType));
            return this;
        }

        /// <summary>
        /// Validates, that expression returns not null or whitespace string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        public ValidationBuilder<T> IsNotNullOrWhitespace(Func<T, string> expression, string message)
        {
            return IsNotNullOrWhitespace(expression, message, ValidationType.Required);
        }

        /// <summary>
        /// Validates, that expression returns not null or whitespace string value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        public ValidationBuilder<T> IsNotNullOrWhitespace(Func<T, string> expression)
        {
            return IsNotNullOrWhitespace(expression, defaultMessage, ValidationType.Required);
        }

        #region Parameterless overloads

        /// <summary>
        /// Validates, that controls property 'Text' returns not null or whitespace string value.
        /// </summary>
        public ValidationBuilder<T> IsNotNullOrWhitespace()
        {
            return IsNotNullOrWhitespace(c => c.Text, defaultMessage, ValidationType.Required);
        }

        #endregion

        #endregion

        #region IsTrue

        /// <summary>
        /// Validates, that expression returns true value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        /// <param name="validationType">Validation type</param>
        public ValidationBuilder<T> IsTrue(Func<T, bool> expression, string message, ValidationType validationType)
        {
            validationSet.AddRule(new ValidationRule((() => expression((T)control)), message, validationType));
            return this;
        }

        /// <summary>
        /// Validates, that expression returns true value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        public ValidationBuilder<T> IsTrue(Func<T, bool> expression, string message)
        {
            return IsTrue(expression, message, ValidationType.Required);
        }

        /// <summary>
        /// Validates, that expression returns true value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        public ValidationBuilder<T> IsTrue(Func<T, bool> expression)
        {
            return IsTrue(expression, defaultMessage, ValidationType.Required);
        }

        #endregion

        #region IsNotNull

        /// <summary>
        /// Validates, that expression returns not null object value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        /// <param name="validationType">Validation type</param>
        public ValidationBuilder<T> IsNotNull(Func<T, object> expression, string message, ValidationType validationType)
        {
            validationSet.AddRule(new ValidationRule(() => expression((T)control) != null, message, validationType));
            return this;
        }

        /// <summary>
        /// Validates, that expression returns not null object value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        /// <param name="message">Message to show if fails</param>
        public ValidationBuilder<T> IsNotNull(Func<T, object> expression, string message)
        {
            return IsNotNull(expression, message, ValidationType.Required);
        }

        /// <summary>
        /// Validates, that expression returns not null object value.
        /// </summary>
        /// <param name="expression">Expression to validate</param>
        public ValidationBuilder<T> IsNotNull(Func<T, object> expression)
        {
            return IsNotNull(expression, defaultMessage, ValidationType.Required);
        }

        #endregion

        #region EnableByValidationResult

        /// <summary>
        /// Sets Enabled property of this control to true if form validation passed or false - if not.
        /// </summary>
        public ValidationBuilder<T> EnableByValidationResult()
        {
            formValidator.ValidationCompleted +=
                result => control.Enabled = result;

            return this;
        }

        #endregion

        #endregion
    }
}
