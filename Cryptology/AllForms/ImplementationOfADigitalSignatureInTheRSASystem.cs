using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptology.AllForms
{
    public partial class ImplementationOfADigitalSignatureInTheRSASystem : Form
    {
        MainForm mainForm;
        byte[] dataM;
        long[] dataS_2;
        long[] original_s2;
        long a;
        long h;
        long p;
        long r;
        long g;
        long S_1;
        long S_1orginal;

        public ImplementationOfADigitalSignatureInTheRSASystem(MainForm mainForm)
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

        private static long ExtendedEuclideanAlgorithm(long a, long b, ref long x, ref long y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            long x1 = 0, y1 = 0;
            long gcd = ExtendedEuclideanAlgorithm(b % a, a, ref x1, ref y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return gcd;
        }
        private static long Calculate_r_1(long p, long r)
        {
            long d = 0, y = 0;
            long gcd = ExtendedEuclideanAlgorithm(p, r, ref d, ref y);

            if (gcd != 1)
            {
                return -1;
            }
            if (d < 0)
            {
                d += r;
            }
            return d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            textBox4.Text = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\C_Sharp Files\\Kryptologi\\Kryptologi\\Task9.Designer.cs";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string textFile = openFileDialog.FileName;
                        string text = File.ReadAllText(textFile);
                        dataM = File.ReadAllBytes(textFile);
                        richTextBox1.Text = string.Join(" ", dataM);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = string.Empty;
            richTextBox3.Text = string.Empty;
            try
            {
                p = Convert.ToInt64(Interaction.InputBox("Enter first number: "));
                g = Convert.ToInt64(Interaction.InputBox("Enter first number: "));
            }
            catch { MessageBox.Show("Bad date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (g > 1 && g < p - 1)
            {
                Random rnd = new Random();
                a = rnd.Next(1, (int)p);
                h = (long)BigInteger.ModPow(g, a, p);
                richTextBox2.Text = $"K: (p: {p}, g: {g}, h: {h}). \nK': (a: {a}).";
                r = rnd.Next(1, (int)(p));

                long r_1 = Calculate_r_1(r, p - 1);
                while (r_1 == -1)
                {
                    r = rnd.Next(1, (int)p);
                    r_1 = Calculate_r_1(r, p - 1);
                }

                S_1 = (long)BigInteger.ModPow(g, r, p);
                long r_stroke = r_1 % (p - 1);

                richTextBox2.Text += $"\nr: {r}, r ': {r_stroke}.";
                textBox3.Text = S_1.ToString();

                dataS_2 = new long[dataM.Length];
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < dataM.Length; i++)
                {
                    var S_2 = ((dataM[i] - a * S_1) * r_stroke) % (p - 1);
                    S_2 = S_2 < 0 ? S_2 + (p - 1) : S_2;
                    dataS_2[i] = S_2;
                    stringBuilder.Append($"{S_2} ");
                }
                textBox4.Text = stringBuilder.ToString();
            }
            else
            {
                MessageBox.Show("Виберіть інші p та q ");
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = string.Empty;

            var g_data = new BigInteger[dataM.Length];
            var h_S_1Data = new BigInteger[dataM.Length];
            var isValid = true;

            for (int i = 0; i < dataM.Length; i++)
            {
                g_data[i] = BigInteger.ModPow(g, dataM[i], p);
                h_S_1Data[i] = (BigInteger.ModPow(h, S_1, p) * BigInteger.ModPow(S_1, dataS_2[i], p)) % p;

                if (g_data[i] != h_S_1Data[i])
                {
                    isValid = false;
                }
            }
            richTextBox3.Text = isValid ? "Цифровий підпис правильний!" : "Підпис не правильний!";
        }

        private void checkMod_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\C_Sharp Files\\Kryptologi\\Kryptologi\\Task9.Designer.cs";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string textFile = openFileDialog.FileName;
                        string text = File.ReadAllText(textFile);
                        dataM = File.ReadAllBytes(textFile);
                        richTextBox1.Text = string.Join(" ", dataM);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                    try
                    {
                        S_1 = Convert.ToInt64(textBox3.Text);

                        var S_2string = textBox4.Text.Trim().Split(' ');
                        dataS_2 = S_2string.Select(x => Convert.ToInt64(x)).ToArray();

                        richTextBox3.Text = string.Empty;
                        var g_data = new BigInteger[dataM.Length];

                        var h_S_1Data = new BigInteger[dataM.Length];
                        var isValid = true;

                        for (int i = 0; i < dataM.Length; i++)
                        {
                            g_data[i] = BigInteger.ModPow(g, dataM[i], p);

                            h_S_1Data[i] = (BigInteger.ModPow(h, S_1, p) * BigInteger.ModPow(S_1, dataS_2[i], p)) % p;

                            if (g_data[i] != h_S_1Data[i])
                            {
                                isValid = false;
                            }
                        }
                        richTextBox3.Text = isValid ? "Цифровий підпис правильний!" : "Підпис не правильний!";
                    }
                    catch
                    {
                        richTextBox3.Text = "Підпис не правильний! ";
                    }
                }
            }
        }
    }
}
