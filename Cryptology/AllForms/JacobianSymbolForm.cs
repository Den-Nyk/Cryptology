using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptology.AllForms
{
    public partial class JacobianSymbolForm : Form
    {
        private MainForm mainForm;
        public JacobianSymbolForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void closeThisForm(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void buttonMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "";
        }

        static long calculateJacobian(long a, long n)
        {
            long ans = 1L;

            if (a < 0)
            {
                a = -a; // (a/n) = (-a/n)*(-1/n)
                if (n % 4 == 3)
                    ans = -ans; // (-1/n) = -1 if n = 3 (mod 4)
            }

            if (a == 1)
                return ans; // (1/n) = 1

            while (a != 0)
            {
                if (a < 0)
                {
                    a = -a; // (a/n) = (-a/n)*(-1/n)
                    if (n % 4 == 3)
                        ans = -ans; // (-1/n) = -1 if n = 3 (mod 4)
                }

                while (a % 2 == 0)
                {
                    a /= 2;
                    if (n % 8 == 3 || n % 8 == 5)
                        ans = -ans;
                }

                long temp = a;
                a = n;
                n = temp;

                if (a % 4 == 3 && n % 4 == 3)
                    ans = -ans;

                a %= n;
                if (a > n / 2)
                    a = a - n;
            }

            if (n == 1)
                return ans;

            return 0;

        }

        static long modulo(long Base, long exponent, long mod)
        {
            long x = 1;
            long y = Base;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    x = (x * y) % mod;

                y = (y * y) % mod;
                exponent = exponent / 2;

            }
            return x % mod;
        }

        // To calculate Jacobian symbol of a given number
        // To perform the Solovay-Strassen Primality Test
        static bool SoloveyStrassen(int p, int iteration, out int iterationNumber)
        {
            iterationNumber = 0;
            if (p < 2)
                return false;
            if (p != 2 && p % 2 == 0)
                return false;

            Random rand = new Random();
            for (int i = 0; i < iteration; i++)
            {
                long r = Math.Abs(rand.Next(1, p));
                long a = r % (p - 1) + 1;
                long jacobian = (p + calculateJacobian(a, p)) % p;
                long mod = modulo(a, (p - 1) / 2, p);

                iterationNumber++;

                if (jacobian == 0 || mod != jacobian)
                {
                    return false;
                }
            }
            return true;
        }

        private void isPrime_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = string.Empty;

            int iter, num1;
            try
            {
                num1 = int.Parse(Interaction.InputBox("Enter first number: "));
                iter = int.Parse(Interaction.InputBox("Enter second number: "));
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SoloveyStrassen(num1, iter, out int iterationCount))
            {
                AnswerBox.Text += (num1 + " is prime\r\n");
                AnswerBox.Text += "Probability: " + ((1 / Math.Pow(2, iterationCount)));
            }
            else
            {
                AnswerBox.Text += (num1 + " is composite\r\n");
                AnswerBox.Text += $"Probability: 100%;";
            }
        }

        private void JacobiSymbol_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "";
            long num1, num2;
            try
            {
                num1 = long.Parse(Interaction.InputBox("Enter first number: "));
                num2 = long.Parse(Interaction.InputBox("Enter second number: "));
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long result = calculateJacobian(num1, num2);
            string output = $"({num1}/{num2}) = {result}";
            AnswerBox.Text = output;
        }
    }
}
