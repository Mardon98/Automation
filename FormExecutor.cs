﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationOfPayrollCalculations
{
    public partial class FormExecutor : Form
    {
        public FormExecutor()
        {
            InitializeComponent();
        }

        private void executorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.executorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automation_of_payroll_calculationsDataSet);

        }

        private void FormExecutor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automation_of_payroll_calculationsDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.automation_of_payroll_calculationsDataSet.Executor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager f2 = new FormManager();
            f2.Show();


            this.Hide();
        }
    }
}
