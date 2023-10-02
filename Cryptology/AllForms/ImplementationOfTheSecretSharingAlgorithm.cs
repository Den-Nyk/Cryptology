using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using Microsoft.VisualBasic;

namespace Cryptology.AllForms
{
    public partial class ImplementationOfTheSecretSharingAlgorithm : Form
    {
        MainForm mainForm;
        public ImplementationOfTheSecretSharingAlgorithm(MainForm mainForm)
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
        public static List<Tuple<int, BigInteger>> GenerateShares(BigInteger secret, int numShares, int threshold)
        {
            List<BigInteger> coefficients = new List<BigInteger>();
            coefficients.Add(secret);
            Random random = new Random();
            for (int i = 1; i < threshold; i++)
            {
                coefficients.Add(RandomBigInteger(random, BigInteger.One, BigInteger.One << 8));
            }

            List<Tuple<int, BigInteger>> shares = new List<Tuple<int, BigInteger>>();
            for (int i = 1; i <= numShares; i++)
            {
                BigInteger x = new BigInteger(i);
                BigInteger y = EvaluatePolynomial(coefficients, x);
                shares.Add(Tuple.Create((int)x, y));
            }

            return shares;
        }

        public BigInteger ReconstructSecret(List<Tuple<int, BigInteger>> shares)
        {
            List<int> xValues = new List<int>();
            List<BigInteger> yValues = new List<BigInteger>();
            foreach (var share in shares)
            {
                xValues.Add(share.Item1);
                textBox1.Text += "Item 1: " + share.Item1;
                yValues.Add(share.Item2);
                textBox1.Text += "Item 2: " + share.Item2;
            }

            textBox1.Text += "x value: " + xValues.ToString() + "\ty value: " + yValues.ToArray().ToString() + "\r\n";
            BigInteger secret = Interpolate(xValues.ToArray(), yValues.ToArray(), BigInteger.Zero);
            return secret;
        }

        private static BigInteger RandomBigInteger(Random random, BigInteger minValue, BigInteger maxValue)
        {
            byte[] bytes = maxValue.ToByteArray();
            random.NextBytes(bytes);
            BigInteger result = new BigInteger(bytes);
            if (result < minValue)
            {
                result = BigInteger.Remainder(result, maxValue - minValue) + minValue;
            }
            return result;
        }

        private static BigInteger EvaluatePolynomial(List<BigInteger> coefficients, BigInteger x)
        {
            BigInteger result = BigInteger.Zero;
            for (int i = 0; i < coefficients.Count; i++)
            {
                result += coefficients[i] * BigInteger.Pow(x, i);
            }
            return result;
        }

        private static BigInteger Interpolate(int[] xValues, BigInteger[] yValues, BigInteger x)
        {
            BigInteger result = BigInteger.Zero;
            for (int i = 0; i < xValues.Length; i++)
            {
                BigInteger term = yValues[i];
                for (int j = 0; j < xValues.Length; j++)
                {
                    if (j != i)
                    {
                        term *= (x - xValues[j]) / (xValues[i] - xValues[j]);
                    }
                }
                result += term;
            }
            return result;
        }

        private void check_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            BigInteger secret = BigInteger.Parse(Interaction.InputBox("Enter secret: ")) ;
            int numShares = int.Parse(Interaction.InputBox("Enter num shares: "));
            int threshold = int.Parse(Interaction.InputBox("Enter threshold: "));

            List<Tuple<int, BigInteger>> shares = GenerateShares(secret, numShares, threshold);
            Console.WriteLine("Shares:");
            foreach (var share in shares)
            {
                textBox1.Text += ($"({share.Item1}, {share.Item2})");
                textBox1.Text += "\r\n";
            }

            if (threshold > numShares)
            {
                textBox1.Text += "No secret.";
            }
            else
            {
                List<Tuple<int, BigInteger>> thresholdShares = shares.GetRange(0, threshold);
                BigInteger reconstructedSecret = ReconstructSecret(thresholdShares);
                textBox1.Text += ("Reconstructed Secret: " + reconstructedSecret);
                textBox1.Text += "\r\n";
            }
        }
    }
}
