using Cryptology.AllForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology
{
    public partial class MainForm : Form
    {
        #region Variables for resize and resize caling
        private Size formOriginalSize;
        private Rectangle recButtonOpenFormConstructionOfFrequencyTables;
        private Rectangle recButtonOpenFormSimpleSubstitutionCipher;
        private Rectangle recButtonOpenFormDecipheringByFrequencyAnalysis;
        private Rectangle recButtonOpenFormWigenerCipher;
        private Rectangle recButtonOpenFormCipherOfADisposableNotebook;
        private Rectangle recButtonToGetAuthorName;
        private Rectangle recButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN;
        private Rectangle recButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity;
        private Rectangle recRSACryptosystem;
        private Rectangle recButtonToOpenImplementationOfADigitalSignatureInTheRSASystem;
        private Rectangle recButtonToOpenImplementationOfTheSecretSharingAlgorithm;

        private void MainForm_Resize(object sender, EventArgs e)
        {
            resize_Control(this, formOriginalSize, ButtonOpenFormConstructionOfFrequencyTables, recButtonOpenFormConstructionOfFrequencyTables);
            resize_Control(this, formOriginalSize, ButtonOpenFormSimpleSubstitutionCipher, recButtonOpenFormSimpleSubstitutionCipher);
            resize_Control(this, formOriginalSize, ButtonOpenFormDecipheringByFrequencyAnalysis, recButtonOpenFormDecipheringByFrequencyAnalysis);
            resize_Control(this, formOriginalSize, ButtonOpenFormWigenerCipher, recButtonOpenFormWigenerCipher);
            resize_Control(this, formOriginalSize, ButtonOpenFormCipherOfADisposableNotebook, recButtonOpenFormCipherOfADisposableNotebook);
            resize_Control(this, formOriginalSize, ButtonToGetAuthorName, recButtonToGetAuthorName);
            resize_Control(this, formOriginalSize, ButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN, recButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN);
            resize_Control(this, formOriginalSize, ButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity, recButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity);
            resize_Control(this, formOriginalSize, ButtonToOpenRSACryptosystem, recRSACryptosystem);
            resize_Control(this, formOriginalSize, ButtonToOpenImplementationOfADigitalSignatureInTheRSASystem, recButtonToOpenImplementationOfADigitalSignatureInTheRSASystem);
            resize_Control(this, formOriginalSize, ButtonToOpenImplementationOfTheSecretSharingAlgorithm, recButtonToOpenImplementationOfTheSecretSharingAlgorithm);
        }
        #endregion

        #region Function to resize form
        public static void resize_Control(Form form, Size formOriginalSize, Control c, Rectangle r)
        {
            double xRatio = (double)(form.Width) / (double)(formOriginalSize.Width);
            double yRatio = (double)(form.Height) / (double)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Inizialization for local variables
            formOriginalSize = this.Size;
            this.Resize += MainForm_Resize;
            recButtonOpenFormConstructionOfFrequencyTables = new Rectangle(ButtonOpenFormConstructionOfFrequencyTables.Location, ButtonOpenFormConstructionOfFrequencyTables.Size);
            recButtonOpenFormSimpleSubstitutionCipher = new Rectangle(ButtonOpenFormSimpleSubstitutionCipher.Location, ButtonOpenFormSimpleSubstitutionCipher.Size);
            recButtonOpenFormDecipheringByFrequencyAnalysis = new Rectangle(ButtonOpenFormDecipheringByFrequencyAnalysis.Location, ButtonOpenFormDecipheringByFrequencyAnalysis.Size);
            recButtonOpenFormWigenerCipher = new Rectangle(ButtonOpenFormWigenerCipher.Location, ButtonOpenFormWigenerCipher.Size);
            recButtonOpenFormCipherOfADisposableNotebook = new Rectangle(ButtonOpenFormCipherOfADisposableNotebook.Location, ButtonOpenFormCipherOfADisposableNotebook.Size);
            recButtonToGetAuthorName = new Rectangle(ButtonToGetAuthorName.Location, ButtonToGetAuthorName.Size);
            recButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN = new Rectangle(ButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN.Location, ButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN.Size);
            recButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity = new Rectangle(ButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity.Location, ButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity.Size);
            recRSACryptosystem=new Rectangle(ButtonToOpenRSACryptosystem.Location, ButtonToOpenRSACryptosystem.Size);
            recButtonToOpenImplementationOfADigitalSignatureInTheRSASystem = new Rectangle(ButtonToOpenImplementationOfADigitalSignatureInTheRSASystem.Location, ButtonToOpenImplementationOfADigitalSignatureInTheRSASystem.Size);
            recButtonToOpenImplementationOfTheSecretSharingAlgorithm = new Rectangle(ButtonToOpenImplementationOfTheSecretSharingAlgorithm.Location, ButtonToOpenImplementationOfTheSecretSharingAlgorithm.Size);
            #endregion
        }

        #region OpenFileDialog function
        public static string openFileDialogToLoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for the file extension and the initial directory.
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = @"C:\Users\asd\source\C#\University\Cryptology\Cryptology\TxtForAllHomeworks\";

            // Show the dialog and check if the user clicked the OK button.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("You haven`t chose file to load table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        private void ButtonToGetAuthorName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danylo Nykolaichuk", "Author", MessageBoxButtons.OK);
        }

        private void ButtonOpenFormConstructionOfFrequencyTables_Click(object sender, EventArgs e)
        {
            var newForm = new ConstructioOfFrequencyTablesForm(this);
            this.Hide();
            newForm.Show();
        }

        private void OpenFormSimpleSubstitutionCipher_Click(object sender, EventArgs e)
        {
            var newForm = new SimpleSubstitutionCipherForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonOpenFormDecipheringByFrequencyAnalysis_Click(object sender, EventArgs e)
        {
            var newForm = new DecipheringByFrequencyAnalysisForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonOpenFormWigenerCipher_Click(object sender, EventArgs e)
        {
            var newForm = new WigenerCipherForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonOpenFormCipherOfADisposableNotebook_Click(object sender, EventArgs e)
        {
            var newForm = new CipherOfADisposableNotebookForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonToOpenExtendedAlgorithmOfEuclidBinaryExponentiationMethodSelectionOfRandomElementsFromRNAndRN_Click(object sender, EventArgs e)
        {
            var newForm = new ExtendedEuclidForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonToOpenAlgorithmForCalculatingTheJacobianSymbolAndTestingANumberForSimplicity_Click(object sender, EventArgs e)
        {
            var newForm = new JacobianSymbolForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonToOpenRSACryptosystem_Click(object sender, EventArgs e)
        {
            var newForm = new RSACryptosystemForm(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonToOpenImplementationOfADigitalSignatureInTheRSASystem_Click(object sender, EventArgs e)
        {
            var newForm = new ImplementationOfADigitalSignatureInTheRSASystem(this);
            this.Hide();
            newForm.Show();
        }

        private void ButtonToOpenImplementationOfTheSecretSharingAlgorithm_Click(object sender, EventArgs e)
        {
            var newForm = new ImplementationOfTheSecretSharingAlgorithm(this);
            this.Hide();
            newForm.Show();
        }
    }
}
