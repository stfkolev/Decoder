using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace GUI
{
    public partial class Form1 : MetroForm
    {
        private string psPath;
        private string outputPath;
        
        public Form1()
        {
            InitializeComponent();
            
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            this.metroTabControl1.Location = new Point(this.Width, this.metroTabControl1.Location.Y);
            this.metroPanel2.Location = new Point(this.metroPanel2.Location.X, 0);
            
            this.ShadowType = MetroFormShadowType.AeroShadow;
            Transitions.Transition iTransition = new Transitions.Transition(new Transitions.TransitionType_Deceleration(1000));
            iTransition.add(this.metroTabControl1, "Left", this.Width - 777);
            iTransition.add(this.metroPanel2, "Top", this.Height - 422);
            iTransition.run();

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = (metroStyleManager1.Theme == MetroFramework.MetroThemeStyle.Light ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            using (var iDialog = new OpenFileDialog())
            {
                iDialog.InitialDirectory = "C:\\";

                iDialog.ValidateNames = false;
                iDialog.CheckFileExists = false;
                iDialog.CheckPathExists = true;

                iDialog.FileName = "Select PluralSight folder";

                if(iDialog.ShowDialog() == DialogResult.OK)
                {
                    this.psPath = Path.GetDirectoryName(iDialog.FileName);
                    this.metroTextBox1.Text = psPath;
                }
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            using (var iDialog = new OpenFileDialog())
            {
                iDialog.InitialDirectory = "C:\\";

                iDialog.ValidateNames = false;
                iDialog.CheckFileExists = false;
                iDialog.CheckPathExists = true;

                iDialog.FileName = "Select output folder";

                if (iDialog.ShowDialog() == DialogResult.OK)
                {
                    this.outputPath = Path.GetDirectoryName(iDialog.FileName);
                    this.metroTextBox2.Text = outputPath;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.outputPath) && !string.IsNullOrWhiteSpace(this.psPath))
            {
                var iDecryptorOptions = new Decoder.Option.DecryptorOptions();

                iDecryptorOptions.InputPath = this.psPath;
                iDecryptorOptions.DatabasePath = this.psPath + "\\pluralsight.db";
                iDecryptorOptions.OutputPath = this.outputPath;

                if(this.useDatabaseCheckbox.Checked)
                {
                    iDecryptorOptions.UseDatabase = true;
                }

                if (this.createSubsCheckbox.Checked)
                {
                    iDecryptorOptions.CreateTranscript = true;
                }

                var iDecryptor = new Decoder.Decryptor(iDecryptorOptions);

                this.metroProgressSpinner1.Visible = true;
                iDecryptor.DecryptAllFolders(iDecryptorOptions.InputPath, iDecryptorOptions.OutputPath);

                this.metroProgressSpinner1.Visible = false;
                this.metroLabel5.Text = "The decryption has been completed!";
                this.metroLabel5.Visible = true;


            }
        }
    }
}
