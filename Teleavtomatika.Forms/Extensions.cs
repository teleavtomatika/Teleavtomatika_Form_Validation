// Copyrigth (c) Teleavtomatika Ltd. All rights reserved.
// Author: Fomin Dmitry
// Date: 2014/01

using System;
using System.Windows.Forms;
using Teleavtomatika.Practices.SafeCoding;

namespace Teleavtomatika.Forms
{
    /// <summary>
    /// Validation builder extensions
    /// </summary>
    public static class Extensions
    {
        #region Control

        /// <summary>
        /// Entrypoint for control validation builder.
        /// </summary>
        public static ValidationBuilder<T> ValidateControl<T>(this T control)
            where T : Control
        {
            return new ValidationBuilder<T>(control);
        }

        /// <summary>
        /// Set enabled state of this control by timer 
        /// </summary>
        public static void EnableByTimer<T>(this T control, Func<bool> enabledExpression)
            where T : Control
        {
            new ValidationBuilder<T>(control).IsTrue(ctl =>
                {
                    ctl.Enabled = enabledExpression();
                    return true;
                });
        }

        /// <summary>
        /// Execute update action for Control by timer.
        /// </summary>
        public static void UpdateByTimer<T>(this T control, Action<T> updateAction)
            where T : Control
        {
            new ValidationBuilder<T>(control).IsTrue(ctl =>
            {
                updateAction(control);
                return true;
            });
        }

        #endregion

        #region ToolStripItem

        /// <summary>
        /// Set enabled state of this ToolStripItem by timer and expression result
        /// </summary>
        public static void EnableItemByTimer<T>(this T control, Func<bool> enabledExpression)
            where T : ToolStripItem
        {
            ValidateArgument.IsNotNull(control);
            control.GetCurrentParent().ValidateControl().IsTrue(ctl =>
            {
                control.Enabled = enabledExpression();
                return true;
            });
        }

        /// <summary>
        /// Set Visibe property of this ToolStripItem by timer and expression result
        /// </summary>
        public static void VisibleItemByTimer<T>(this T control, Func<bool> visibleExpression)
            where T : ToolStripItem
        {
            ValidateArgument.IsNotNull(control);
            control.GetCurrentParent().ValidateControl().IsTrue(ctl =>
            {
                control.Visible = visibleExpression();
                return true;
            });
        }

        /// <summary>
        /// Execute update action for ToolStripItem by timer.
        /// </summary>
        public static void UpdateItemByTimer<T>(this T control, Action<T> updateAction)
            where T : ToolStripItem
        {
            ValidateArgument.IsNotNull(control);
            control.GetCurrentParent().ValidateControl().IsTrue(ctl =>
            {
                updateAction(control);
                return true;
            });
        }

        #endregion

        #region ToolStripButton

        /// <summary>
        /// Sets Checked property for corresponding ToolStripButton according on provided checkedExpression.
        /// </summary>
        public static void CheckButtonByTimer<T>(this T control, Func<bool> checkedExpression)
            where T : ToolStripButton
        {
            ValidateArgument.IsNotNull(control);
            control.GetCurrentParent().ValidateControl().IsTrue(ctl =>
            {
                control.Checked = checkedExpression();
                return true;
            });
        }

        #endregion

        #region TextBox

        /// <summary>
        /// Validates if corresponding TextBox.Text property contains valid e-mail address.
        /// </summary>
        /// <typeparam name="T">TextBox type</typeparam>
        /// <param name="builder">Validation builder</param>
        /// <param name="validIfEmpty">If set to true - Assume that e-mail is valid when Text property is empty or null.</param>
        public static ValidationBuilder<T> IsValidEMail<T>(this ValidationBuilder<T> builder, bool validIfEmpty)
            where T : TextBox
        {
            if (!validIfEmpty)
            {
                return builder.IsTrue(c => c.Text.IsValidEmailAddress(), "Адрес электронной почты указан неверно.");
            }
            else
            {
                return builder.IsTrue(c => string.IsNullOrEmpty(c.Text) || c.Text.IsValidEmailAddress(), "Адрес электронной почты указан неверно.");
            }
        }

        #endregion
    }
}


