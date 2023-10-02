using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptology.AllForms
{
    public partial class ExtendedEuclidForm : Form
    {
        private MainForm mainForm;

        #region Variables for resize and resize realization
        private Size formOriginalSize;
        private Rectangle recanswer;
        private Rectangle recbuttonMainForm;
        private Rectangle recstartEuclid;
        private Rectangle recbinaryButton;
        private Rectangle reczButton;
        private Rectangle rectextBox1;
        private Rectangle recrandomButton;
        private Rectangle recReset;

        private void ConstructioOfFrequencyTablesForm_Resiz(object sender, EventArgs e)
        {
            MainForm.resize_Control(this, formOriginalSize, answer, recanswer);
            MainForm.resize_Control(this, formOriginalSize, buttonMainForm, recbuttonMainForm);
            MainForm.resize_Control(this, formOriginalSize, binaryButton, recbinaryButton);
            MainForm.resize_Control(this, formOriginalSize, startEuclid, recstartEuclid);
            MainForm.resize_Control(this, formOriginalSize, zButton, reczButton);
            MainForm.resize_Control(this, formOriginalSize, textBox1, rectextBox1);
            MainForm.resize_Control(this, formOriginalSize, randomButton, recrandomButton);
            MainForm.resize_Control(this, formOriginalSize, reset, recReset);
        }
        #endregion
        public ExtendedEuclidForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            #region Initializate variables for resize
            this.Resize += ConstructioOfFrequencyTablesForm_Resiz;
            formOriginalSize = this.Size;
            recanswer = new Rectangle(answer.Location, answer.Size);
            recbuttonMainForm = new Rectangle(buttonMainForm.Location, buttonMainForm.Size);
            recstartEuclid = new Rectangle(startEuclid.Location, startEuclid.Size);
            recbinaryButton = new Rectangle(binaryButton.Location, binaryButton.Size);
            reczButton = new Rectangle(zButton.Location, zButton.Size);
            rectextBox1 = new Rectangle(textBox1.Location, textBox1.Size);
            recrandomButton = new Rectangle(randomButton.Location, randomButton.Size);
            recReset = new Rectangle(reset.Location, reset.Size);
            #endregion
        }

        private void closeThisForm(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static string Euclid(int a, int b)
        {
            if (b == 0)
            {
                return $"GCD({a},{b})={a}, x={1}, y={0}";
            }
            // Initialize variables for the algorithm
            int r0 = a;
            int r1 = b;
            int x0 = 1;
            int y1 = 1;
            int y0 = 0;
            int x1 = 0;
            int i = 1;
            int q;
            // Loop until the remainder is zero
            while (r1 > 0)
            {
                // Calculate the quotient and remainder
                int temp = r1;
                q = r0 / r1;
                r1 = r0 % r1;
                r0 = temp;

                // Update the Bezout coefficients
                int tempX = x1;
                int tempY = y1;
                x1 = x0 - q * x1;
                x0 = tempX;
                y1 = y0 - q * y1;
                y0 = tempY;

                i++;
            }
            // Return the result as a string
            return $"GCD({a},{b})={r0}\r\n x={x0}\r\n y={y0}";
        }

        private void startEuclid_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            string a, b;
            try
            {
                a = Interaction.InputBox("Please enter the first number ", "First number");
                b = Interaction.InputBox("Please enter second number ", "second number");
                answer.Text = Euclid(int.Parse(a), int.Parse(b));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 404");
            }
        }

        private static int Euclid1(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            int r0 = a;
            int r1 = b;
            int u0 = 1;
            int v1 = 1;
            int v0 = 0;
            int u1 = 0;
            int i = 1;
            int q;
            while (r1 > 0)
            {
                int temp = r1;
                q = r0 / r1;
                r1 = r0 % r1;
                r0 = temp;

                int tempU = u1;
                int tempV = v1;
                u1 = u0 - q * u1;
                u0 = tempU;

                v1 = v0 - q * v1;
                v0 = tempV;

                i++;
            }
            return r0;
        }



        private static int power(int x, int y, int p)
        {
            int res = 1;
            x = x % p;
            if (x == 0)
            {
                return 0;
            }
            while (y > 0)
            {
                if ((y & 1) != 0)
                {
                    res = (res * x) % p;
                }

                y = y >> 1;
                x = (x * x) % p;
            }
            return res;
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            try
            {
                string x1 = Interaction.InputBox("Please enter the first number ", "First number");
                string d1d = Interaction.InputBox("Please enter second number ", "second number");
                string m1 = Interaction.InputBox("Please enter mod ", "mod");
                int x = Convert.ToInt32(x1);
                int d = Convert.ToInt32(d1d);
                int n = Convert.ToInt32(m1);
                answer.Text = $"{power(x, d, n)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 404");
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            string n1 = textBox1.Text;
            int n = Convert.ToInt32(n1);
            int l = Convert.ToInt32((Math.Log(n, 2)));
            if (Math.Pow(2, l) < n)
            {
                l += 1;
            }
            var r = new Random();
            int x = r.Next(0, Convert.ToInt32(Math.Pow(2, l)));
            while (x >= n)
            {
                x = r.Next(0, Convert.ToInt32(Math.Pow(2, l)));
            }
            answer.Text = x.ToString();
        }

        private void zButton_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            string n2 = textBox1.Text;
            int n = Convert.ToInt32(n2);
            int l = Convert.ToInt32((Math.Log(n, 2)));
            if (Math.Pow(2, l) < n)
            {
                l += 1;
            }
            var r = new Random();
            int x = r.Next(1, Convert.ToInt32(Math.Pow(2, l)));
            while (x >= n || Euclid1(n, x) != 1)
            {
                x = r.Next(1, Convert.ToInt32(Math.Pow(2, l)));
            }
            answer.Text = x.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            answer.Text = "";
        }
    }
}
