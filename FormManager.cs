using System;
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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExecutor f2 = new FormExecutor();
            f2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCoefficient f2 = new FormCoefficient();
            f2.Show();

            this.Hide();
        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automation_of_payroll_calculationsDataSet);

        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automation_of_payroll_calculationsDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.automation_of_payroll_calculationsDataSet.Manager);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAutorization f2 = new FormAutorization();
            f2.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTask f2 = new FormTask();
            f2.Show();

            this.Hide();

        }
    }
}
