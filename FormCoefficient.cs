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
    public partial class FormCoefficient : Form
    {
        public FormCoefficient()
        {
            InitializeComponent();
        }

        private void coefficientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coefficientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automation_of_payroll_calculationsDataSet);

        }

        private void FormCoefficient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automation_of_payroll_calculationsDataSet.Coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.automation_of_payroll_calculationsDataSet.Coefficient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager f1 = new FormManager();
            f1.Show();

            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCoefficientRed f4 = new FormCoefficientRed();
            f4.Show();

            this.Hide();
        }
    }
}
