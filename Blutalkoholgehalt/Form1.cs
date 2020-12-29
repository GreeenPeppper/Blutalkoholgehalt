using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blutalkoholgehalt
{
    public partial class Form1 : Form
    {
        private float genderConst;

        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate(int amount, float alkAmount, int gender, int weight)
        {
            // Step 1:
            float first = amount * (alkAmount/100);

            // Step 2:
            if (gender == 0) genderConst = 0.6f; // Männlich
            if (gender == 1) genderConst = 0.7f; // Weiblich

            float seccond = genderConst * weight;

            label9.Text = first.ToString();
            label6.Text = seccond.ToString();

            label10.Text = (first / seccond).ToString();

            return;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Calculate(Int16.Parse(amountTextBox.Text), Int16.Parse(alkAmountTextBox.Text), genderList.SelectedIndex, Int16.Parse(kgKGTextBox.Text));
        }
    }
}
