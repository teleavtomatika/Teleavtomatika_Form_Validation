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
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();

            // список чекбоксов с категориями
            var categoryCheckBoxes = pnlCategories.Controls.Cast<CheckBox>();

            // управление состоянием контролов в зависимости от включенных чекбоксов
            dtBegin.EnableByTimer(() => chkFilterByDate.Checked);
            dtEnd.EnableByTimer(() => chkFilterByDate.Checked);
            pnlCategories.EnableByTimer(() => chkFilterByCategory.Checked);
            pnlTextFilter.EnableByTimer(() => chkFilterByText.Checked);

            // теперь правила валидации:
            // если фильтр по дате включен, то начальная дата должна быть меньше либо равна конечной
            // начальная дата не может быть раньше 1990 года
            // валидация будет происходить в обоих DatePicker'ах, но индикация будет отображаться только на dtEnd
            dtEnd
                .ValidateControl()
                .IsTrue(ctl => !chkFilterByDate.Checked || dtBegin.Value >= new DateTime(1990, 1, 1), "Начальная дата отбора не может быть раньше 1990 года")
                .IsTrue(ctl => !chkFilterByDate.Checked || dtBegin.Value <= dtEnd.Value, "Начальная дата должна быть меньше или равной конечной");

            // если осуществляется фильтрация по категориям
            // то необходимо выбрать категорию
            pnlCategories
                .ValidateControl()
                .IsTrue(ctl => !chkFilterByCategory.Checked || categoryCheckBoxes.Any(c => c.Checked), "Необходимо выбрать категорию");

            // если осуществляется поиск текста
            // то необходимо задать текст
            // и выбрать где его искать
            pnlTextFilter
                .ValidateControl()
                .IsTrue(ctl => !chkFilterByText.Checked || chkSearchTextInBody.Checked || chkSearchTextInHeader.Checked, "Необходимо выбрать места поиска текста")
                .IsTrue(ctl => !chkFilterByText.Checked || !string.IsNullOrWhiteSpace(txtSearchText.Text), "Необходимо задать текст");

            // должен быть задан хотя-бы один из фильтров для поиска
            gbSearchParameters
                .ValidateControl()
                .IsTrue(ctl => chkFilterByCategory.Checked || chkFilterByDate.Checked || chkFilterByText.Checked,
                        "Необходимо задать условия поиска.");

            butSearch
                .ValidateControl()
                .EnableByValidationResult();
        }
    }
}
