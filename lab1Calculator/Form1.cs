using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1Calculator
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }



        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        int x;
        double[] arr1 = new double[100];

        TextBox a;
        public void createbox()
        {
            x = int.Parse(txtX.Text);
            flowLayoutPanelPx.Controls.Clear();
            for (int i = 1; i < x + 1; i++)
            {
                TextBox a = new TextBox();
                a.Name = "txtPx" + i.ToString();
                a.AutoSize = true;
                a.Tag = "text";

                flowLayoutPanelPx.Controls.Add(a);
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            createbox();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x; i++)
            {


                arr1[i] = double.Parse((flowLayoutPanelPx.Controls[i] as TextBox).Text);


            }
            Calculate(x, arr1);
        }
        public void Calculate(int x, double[] arr1)
        {
            double[] amount = new double[x];
            double[] avgAmount = new double[x];
            double averageAmount = 0;
            double dispersion = 0; // new double[value];
            double dispersionOfRndVariable = 0;
            double randomVariable = 0;
            string s = "";
            for (int i = 0; i < x; i++)
            {
                amount[i] = -Math.Log(arr1[i], 2);
                avgAmount[i] = amount[i] * arr1[i];
                s = s + " \t" + amount[i];
                //txtAmount.Text += txtAmount.Text + " " + amount[i];
               
                averageAmount += avgAmount[i];
            }

            txtAmount.Text =  s;
            txtAvg.Text = averageAmount.ToString();

            for (int i = 0; i < x; i++)
            {
                dispersion += (Math.Pow((amount[i] - averageAmount), 2)) * arr1[i];
            }
            double ms = Math.Sqrt(dispersion);

            // ---------------
            txtDispersion.Text = dispersion.ToString();
            txtDeviation.Text = ms.ToString();
            

        }

    

    private void txtPx_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;
        if (!char.IsDigit(ch) && ch != 8 && ch != 46)
        {
            e.Handled = true;

        }
    }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            flowLayoutPanelPx.Controls.Clear();
            txtAvg.Clear();
            txtDeviation.Clear();
            txtDispersion.Clear();
            txtX.Clear();
        }
    }
}
