using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleAreaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            try
            {
                double baset = double.Parse(txtBase.Text);
                double heightt = double.Parse(txtHeight.Text);

                double result = (baset * heightt) / 2;


                txbResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Dados inválidos informados");
                txbResult.Clear();
                txtBase.Clear();
                txtHeight.Clear();
            }
            
        }
    }
}
