namespace LexicalAnalyzer
{
    partial class frmLexicalAnalyzer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new CloudToolkitN6.CloudDesktopButton();
            this.btnGenerate = new CloudToolkitN6.CloudDesktopButton();
            this.btnCancel = new CloudToolkitN6.CloudDesktopButton();
            this.rTextSource = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new CloudToolkitN6.CloudDesktopButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Libraries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReserveWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(23, 52);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(382, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.AnimationSpeed = 5;
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundOpacity = 100;
            this.btnOpen.BackgroundOpacity_MouseDown = 170;
            this.btnOpen.BorderColor = System.Drawing.Color.White;
            this.btnOpen.BorderOpacity = 170;
            this.btnOpen.BorderWidth = 1;
            this.btnOpen.ControlText = "Open";
            this.btnOpen.CornerRadius = 12;
            this.btnOpen.DrawBlackTextBackground = true;
            this.btnOpen.FillColor = System.Drawing.Color.Azure;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Icon = global::LexicalAnalyzer.Properties.Resources.mydocuments;
            this.btnOpen.Location = new System.Drawing.Point(411, 41);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 96);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AnimationSpeed = 5;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundOpacity = 100;
            this.btnGenerate.BackgroundOpacity_MouseDown = 170;
            this.btnGenerate.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.BorderOpacity = 170;
            this.btnGenerate.BorderWidth = 1;
            this.btnGenerate.ControlText = "Generate";
            this.btnGenerate.CornerRadius = 12;
            this.btnGenerate.DrawBlackTextBackground = true;
            this.btnGenerate.FillColor = System.Drawing.Color.Azure;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Icon = global::LexicalAnalyzer.Properties.Resources.package_editorspackage_editors;
            this.btnGenerate.Location = new System.Drawing.Point(411, 169);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 96);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationSpeed = 5;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundOpacity = 100;
            this.btnCancel.BackgroundOpacity_MouseDown = 170;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderOpacity = 170;
            this.btnCancel.BorderWidth = 1;
            this.btnCancel.ControlText = "Cancel";
            this.btnCancel.CornerRadius = 12;
            this.btnCancel.DrawBlackTextBackground = true;
            this.btnCancel.FillColor = System.Drawing.Color.Azure;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Icon = global::LexicalAnalyzer.Properties.Resources.kxconfig;
            this.btnCancel.Location = new System.Drawing.Point(411, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 96);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rTextSource
            // 
            this.rTextSource.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextSource.Location = new System.Drawing.Point(23, 140);
            this.rTextSource.Name = "rTextSource";
            this.rTextSource.Size = new System.Drawing.Size(382, 247);
            this.rTextSource.TabIndex = 5;
            this.rTextSource.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source Code";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToOrderColumns = true;
            this.dgvOutput.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libraries,
            this.ReserveWords,
            this.VariableNames,
            this.Operators});
            this.dgvOutput.Location = new System.Drawing.Point(547, 52);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(446, 247);
            this.dgvOutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(624, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generated Tokens And Lexemes";
            // 
            // btnBack
            // 
            this.btnBack.AnimationSpeed = 5;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundOpacity = 100;
            this.btnBack.BackgroundOpacity_MouseDown = 170;
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.BorderOpacity = 170;
            this.btnBack.BorderWidth = 1;
            this.btnBack.ControlText = "Back";
            this.btnBack.CornerRadius = 12;
            this.btnBack.DrawBlackTextBackground = true;
            this.btnBack.FillColor = System.Drawing.Color.Azure;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Icon = global::LexicalAnalyzer.Properties.Resources.exit;
            this.btnBack.Location = new System.Drawing.Point(893, 309);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 96);
            this.btnBack.TabIndex = 9;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Libraries
            // 
            this.Libraries.HeaderText = "Libraries";
            this.Libraries.Name = "Libraries";
            // 
            // ReserveWords
            // 
            this.ReserveWords.HeaderText = "Reserve Words & Datatypes";
            this.ReserveWords.Name = "ReserveWords";
            // 
            // VariableNames
            // 
            this.VariableNames.HeaderText = "Variable Names";
            this.VariableNames.Name = "VariableNames";
            // 
            // Operators
            // 
            this.Operators.HeaderText = "Operators";
            this.Operators.Name = "Operators";
            // 
            // frmLexicalAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LexicalAnalyzer.Properties.Resources.videos_4_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 417);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rTextSource);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmLexicalAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lexical Analyzer";
            this.Load += new System.EventHandler(this.frmLexicalAnalyzer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private CloudToolkitN6.CloudDesktopButton btnOpen;
        private CloudToolkitN6.CloudDesktopButton btnGenerate;
        private CloudToolkitN6.CloudDesktopButton btnCancel;
        private System.Windows.Forms.RichTextBox rTextSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label label3;
        private CloudToolkitN6.CloudDesktopButton btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libraries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReserveWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operators;

        public System.EventHandler btnGenerate_DoubleClick { get; set; }
    }
}

