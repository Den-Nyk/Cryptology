using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptology.AllForms
{
    public partial class RSACryptosystemForm : Form
    {
        private MainForm mainForm;
        public RSACryptosystemForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
            pTextBox.Text= string.Empty;
            QTextBox.Text= string.Empty;
            dTextBox.Text= string.Empty;
            nTextBox.Text= string.Empty;
            allDateBox.Text= string.Empty;
        }

        char[] characters = new char[256];
        private bool IsPrime(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;

        }
        private List<string> RSA_Encode(string s, long e, long n)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                BigInteger bi = new BigInteger(index);

                bi = BigInteger.ModPow(bi, e, n);

                result.Add(bi.ToString());
            }

            return result;
        }

        private string RSA_Decode(List<string> input, long d, long n)
        {
            StringBuilder resultBuilder = new StringBuilder();

            foreach (string item in input)
            {
                if (item.Trim() != "")
                {
                    long[] cipher = item.Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
                    for (int i = 0; i < cipher.Length; i++)
                    {
                        long m = to_power(cipher[i], d, n);
                        resultBuilder.Append((char)m);
                    }
                }
            }

            return resultBuilder.ToString();
        }


        private long to_power(long a, long b, long n)
        {
            long res = 1;

            while (b > 0)
            {
                if ((b & 1) == 1)
                {
                    res = (res * a) % n;
                }
                a = (a * a) % n;
                b >>= 1;
            }

            return res;
        }
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }
        private long Calculate_e(long d, long m)
        {
            long e = 2;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            if ((pTextBox.Text.Length > 0) && (QTextBox.Text.Length > 0))
            {
                long p = Convert.ToInt64(pTextBox.Text);
                long q = Convert.ToInt64(QTextBox.Text);

                if (IsPrime(p) && IsPrime(q))
                {
                    string s = allDateBox.Text;
                    allDateBox.Text = "";

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = new List<string>();
                    foreach (char c in s)
                    {
                        long charNum = (long)c;
                        long encCharNum = (long)BigInteger.ModPow(charNum, e_, n);
                        result.Add(encCharNum.ToString());
                    }

                    allDateBox.Text = string.Join(" ", result);

                    dTextBox.Text = d.ToString();
                    nTextBox.Text = n.ToString();

                }
                else
                    MessageBox.Show("p або q не являються простими числами!");
            }
            else
                MessageBox.Show("Введіть p або q!");
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if ((dTextBox.Text.Length > 0) && (nTextBox.Text.Length > 0))
            {
                long d = Convert.ToInt64(dTextBox.Text);
                long n = Convert.ToInt64(nTextBox.Text);

                List<string> input = new List<string>();
                var text = allDateBox.Text;
                allDateBox.Text = "";
                var textList = text.Split(' ');

                for (int i = 0; i < textList.Length; i++)
                {
                    input.Add(textList[i]);
                }

                string result = RSA_Decode(input, d, n);

                allDateBox.Text += result;
            }
            else
                MessageBox.Show("Введіть секретний ключ!");
        }
    }
}
