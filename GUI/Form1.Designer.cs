namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.downloadTab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.removeFolderCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.createSubsCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.useOutputFolderCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.useDatabaseCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.downloadTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(99, 6);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "On";
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Dark Mode:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroToggle1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(574, 23);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 29);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.downloadTab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(751, 364);
            this.metroTabControl1.TabIndex = 6;
            // 
            // downloadTab
            // 
            this.downloadTab.Controls.Add(this.metroLabel5);
            this.downloadTab.Controls.Add(this.metroProgressSpinner1);
            this.downloadTab.Controls.Add(this.metroButton1);
            this.downloadTab.Controls.Add(this.metroLabel4);
            this.downloadTab.Controls.Add(this.metroLabel3);
            this.downloadTab.Controls.Add(this.metroTextBox2);
            this.downloadTab.Controls.Add(this.metroLabel2);
            this.downloadTab.Controls.Add(this.metroTextBox1);
            this.downloadTab.Controls.Add(this.removeFolderCheckbox);
            this.downloadTab.Controls.Add(this.createSubsCheckbox);
            this.downloadTab.Controls.Add(this.useOutputFolderCheckbox);
            this.downloadTab.Controls.Add(this.useDatabaseCheckbox);
            this.downloadTab.HorizontalScrollbarBarColor = true;
            this.downloadTab.Location = new System.Drawing.Point(4, 35);
            this.downloadTab.Margin = new System.Windows.Forms.Padding(5);
            this.downloadTab.Name = "downloadTab";
            this.downloadTab.Size = new System.Drawing.Size(743, 325);
            this.downloadTab.TabIndex = 0;
            this.downloadTab.Text = "Download";
            this.downloadTab.VerticalScrollbarBarColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(5, 167);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Decrypt";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(547, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Optionals";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(150, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Output Directory:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(5, 112);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.ReadOnly = true;
            this.metroTextBox2.Size = new System.Drawing.Size(281, 23);
            this.metroTextBox2.TabIndex = 10;
            this.metroTextBox2.Text = "Choose Path";
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(1, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Pluralsight Directory:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(3, 44);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.Size = new System.Drawing.Size(281, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.Text = "Choose Path";
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // removeFolderCheckbox
            // 
            this.removeFolderCheckbox.AutoSize = true;
            this.removeFolderCheckbox.Location = new System.Drawing.Point(547, 113);
            this.removeFolderCheckbox.Name = "removeFolderCheckbox";
            this.removeFolderCheckbox.Size = new System.Drawing.Size(187, 15);
            this.removeFolderCheckbox.TabIndex = 7;
            this.removeFolderCheckbox.Text = "Remove folder after encryption";
            this.removeFolderCheckbox.UseVisualStyleBackColor = true;
            // 
            // createSubsCheckbox
            // 
            this.createSubsCheckbox.AutoSize = true;
            this.createSubsCheckbox.Checked = true;
            this.createSubsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createSubsCheckbox.Location = new System.Drawing.Point(547, 92);
            this.createSubsCheckbox.Name = "createSubsCheckbox";
            this.createSubsCheckbox.Size = new System.Drawing.Size(105, 15);
            this.createSubsCheckbox.TabIndex = 6;
            this.createSubsCheckbox.Text = "Create Subtitles";
            this.createSubsCheckbox.UseVisualStyleBackColor = true;
            // 
            // useOutputFolderCheckbox
            // 
            this.useOutputFolderCheckbox.AutoSize = true;
            this.useOutputFolderCheckbox.Checked = true;
            this.useOutputFolderCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useOutputFolderCheckbox.Location = new System.Drawing.Point(547, 71);
            this.useOutputFolderCheckbox.Name = "useOutputFolderCheckbox";
            this.useOutputFolderCheckbox.Size = new System.Drawing.Size(119, 15);
            this.useOutputFolderCheckbox.TabIndex = 5;
            this.useOutputFolderCheckbox.Text = "Use Output Folder";
            this.useOutputFolderCheckbox.UseVisualStyleBackColor = true;
            // 
            // useDatabaseCheckbox
            // 
            this.useDatabaseCheckbox.AutoSize = true;
            this.useDatabaseCheckbox.Checked = true;
            this.useDatabaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDatabaseCheckbox.Location = new System.Drawing.Point(547, 50);
            this.useDatabaseCheckbox.Name = "useDatabaseCheckbox";
            this.useDatabaseCheckbox.Size = new System.Drawing.Size(93, 15);
            this.useDatabaseCheckbox.TabIndex = 4;
            this.useDatabaseCheckbox.Text = "Use Database";
            this.useDatabaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(86, 167);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(40, 23);
            this.metroProgressSpinner1.TabIndex = 14;
            this.metroProgressSpinner1.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(93, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "metroLabel5";
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "PluralSight Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.downloadTab.ResumeLayout(false);
            this.downloadTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage downloadTab;
        private MetroFramework.Controls.MetroCheckBox removeFolderCheckbox;
        private MetroFramework.Controls.MetroCheckBox createSubsCheckbox;
        private MetroFramework.Controls.MetroCheckBox useOutputFolderCheckbox;
        private MetroFramework.Controls.MetroCheckBox useDatabaseCheckbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

