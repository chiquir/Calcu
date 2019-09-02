using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        string c;
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        private void Btndivi_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);

            c = "/";

            this.txtpantalla.Clear();

            this.txtpantalla.Focus();
        }

        private void Btnmenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);

            c = "-";

            this.txtpantalla.Clear();

            this.txtpantalla.Focus();
        }

        private void Btnmulti_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);

            c = "*";

            this.txtpantalla.Clear();

            this.txtpantalla.Focus();
        }

        private void Btnmas_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);

            c = "+";

            this.txtpantalla.Clear();

            this.txtpantalla.Focus();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);

            c = "%";

            this.txtpantalla.Clear();

            this.txtpantalla.Focus();
        }

        private void Btnpunto_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains('.') == false)

            {

                this.txtpantalla.Text = this.txtpantalla.Text + ".";

            }
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {

                b = Convert.ToDouble(this.txtpantalla.Text);

                switch (c)

                {

                    case "+":

                        this.txtpantalla.Text = Convert.ToString(b + a);

                        break;



                    case "-":

                        this.txtpantalla.Text = Convert.ToString(a - b);

                        break;



                    case "*":

                        this.txtpantalla.Text = Convert.ToString(b * a);

                        break;



                    case "/":

                        this.txtpantalla.Text = Convert.ToString(a / b);

                        break;

                case "%":

                    this.txtpantalla.Text = Convert.ToString(a *(b/100));

                    break;

            }
        }

        private void Btnce_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
        }

        private void Btnc_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
        }
    }
}
