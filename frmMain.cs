using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Teleavtomatika.Forms;

namespace Teleavtomatika_Form_Validation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // проверим, что текстовые поля заполнены 
            txtSurname
                .ValidateControl()
                .IsNotNullOrWhitespace();

            txtName
                .ValidateControl()
                .IsNotNullOrWhitespace();

            txtMiddleName
                .ValidateControl()
                .IsNotNullOrWhitespace();

            // зададим жесткое ограничение в 16 лет
            // и нежесткое ограничение (предупреждение не препятствующее вводу формы) в 21 год
            nmAge
                .ValidateControl()
                .IsTrue(ctl => ctl.Value >= 16, "Возраст должен быть не менее 16 лет.", ValidationType.Required)
                .IsTrue(ctl => ctl.Value >= 21, "Некоторый контент (21+) для вас будет недоступен.", ValidationType.Optional);

            // включим проверку на ввод корректного e-mail'а в этом поле
            txtEMail
                .ValidateControl()
                .IsValidEMail(false);

            // по результатам валидации будем разрешать/запрещать указанную кнопку
            butSave
                .ValidateControl()
                .EnableByValidationResult();
        }
    }
}
