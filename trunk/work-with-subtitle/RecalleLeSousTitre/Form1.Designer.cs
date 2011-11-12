namespace RecalleLeSousTitre
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFirstError = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNumeroLigne = new System.Windows.Forms.Label();
            this.lblTempsDebut = new System.Windows.Forms.Label();
            this.lblTempsFin = new System.Windows.Forms.Label();
            this.lblNumeroLigneAfter = new System.Windows.Forms.Label();
            this.lblTempsDebutAfter = new System.Windows.Forms.Label();
            this.lblTempsFinAfter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNumeroLigneBefore = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTempsDebutBefore = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTempsFinBefore = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.lblColorBefore = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorAfter = new System.Windows.Forms.Label();
            this.btnFoundErrors = new System.Windows.Forms.Button();
            this.btnNextError = new System.Windows.Forms.Button();
            this.btnRewindError = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.UpDownSecondsError = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBoxBefore = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAfter = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGoTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBefore = new System.Windows.Forms.Panel();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.panelAfter = new System.Windows.Forms.Panel();
            this.lblMaxLine = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSecondsError)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoTo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelBefore.SuspendLayout();
            this.panelCurrent.SuspendLayout();
            this.panelAfter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "parcourir ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Charger tout le fichier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Charger_Click);
            // 
            // btnFirstError
            // 
            this.btnFirstError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstError.Location = new System.Drawing.Point(24, 47);
            this.btnFirstError.Name = "btnFirstError";
            this.btnFirstError.Size = new System.Drawing.Size(75, 23);
            this.btnFirstError.TabIndex = 3;
            this.btnFirstError.Text = "<<";
            this.btnFirstError.UseVisualStyleBackColor = true;
            this.btnFirstError.Click += new System.EventHandler(this.BtnFirstError_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(692, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SaveFile";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblNumeroLigne
            // 
            this.lblNumeroLigne.AutoSize = true;
            this.lblNumeroLigne.Location = new System.Drawing.Point(89, 13);
            this.lblNumeroLigne.Name = "lblNumeroLigne";
            this.lblNumeroLigne.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigne.TabIndex = 5;
            this.lblNumeroLigne.Text = "label1";
            // 
            // lblTempsDebut
            // 
            this.lblTempsDebut.AutoSize = true;
            this.lblTempsDebut.Location = new System.Drawing.Point(89, 36);
            this.lblTempsDebut.Name = "lblTempsDebut";
            this.lblTempsDebut.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebut.TabIndex = 6;
            this.lblTempsDebut.Text = "label2";
            // 
            // lblTempsFin
            // 
            this.lblTempsFin.AutoSize = true;
            this.lblTempsFin.Location = new System.Drawing.Point(89, 59);
            this.lblTempsFin.Name = "lblTempsFin";
            this.lblTempsFin.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFin.TabIndex = 6;
            this.lblTempsFin.Text = "label4";
            // 
            // lblNumeroLigneAfter
            // 
            this.lblNumeroLigneAfter.AutoSize = true;
            this.lblNumeroLigneAfter.Location = new System.Drawing.Point(78, 13);
            this.lblNumeroLigneAfter.Name = "lblNumeroLigneAfter";
            this.lblNumeroLigneAfter.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigneAfter.TabIndex = 5;
            this.lblNumeroLigneAfter.Text = "label1";
            // 
            // lblTempsDebutAfter
            // 
            this.lblTempsDebutAfter.AutoSize = true;
            this.lblTempsDebutAfter.Location = new System.Drawing.Point(78, 36);
            this.lblTempsDebutAfter.Name = "lblTempsDebutAfter";
            this.lblTempsDebutAfter.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebutAfter.TabIndex = 6;
            this.lblTempsDebutAfter.Text = "label2";
            // 
            // lblTempsFinAfter
            // 
            this.lblTempsFinAfter.AutoSize = true;
            this.lblTempsFinAfter.Location = new System.Drawing.Point(78, 59);
            this.lblTempsFinAfter.Name = "lblTempsFinAfter";
            this.lblTempsFinAfter.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFinAfter.TabIndex = 6;
            this.lblTempsFinAfter.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro ligne";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Temps début";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Temp Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Numéro ligne";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Temps début";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Temp Fin";
            // 
            // lblNumeroLigneBefore
            // 
            this.lblNumeroLigneBefore.AutoSize = true;
            this.lblNumeroLigneBefore.Location = new System.Drawing.Point(86, 13);
            this.lblNumeroLigneBefore.Name = "lblNumeroLigneBefore";
            this.lblNumeroLigneBefore.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigneBefore.TabIndex = 5;
            this.lblNumeroLigneBefore.Text = "label1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Numéro ligne";
            // 
            // lblTempsDebutBefore
            // 
            this.lblTempsDebutBefore.AutoSize = true;
            this.lblTempsDebutBefore.Location = new System.Drawing.Point(86, 36);
            this.lblTempsDebutBefore.Name = "lblTempsDebutBefore";
            this.lblTempsDebutBefore.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebutBefore.TabIndex = 6;
            this.lblTempsDebutBefore.Text = "label2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Temps début";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Temp Fin";
            // 
            // lblTempsFinBefore
            // 
            this.lblTempsFinBefore.AutoSize = true;
            this.lblTempsFinBefore.Location = new System.Drawing.Point(86, 59);
            this.lblTempsFinBefore.Name = "lblTempsFinBefore";
            this.lblTempsFinBefore.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFinBefore.TabIndex = 6;
            this.lblTempsFinBefore.Text = "label4";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(585, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewind.Location = new System.Drawing.Point(105, 19);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(75, 23);
            this.btnRewind.TabIndex = 9;
            this.btnRewind.Text = "<";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.BtnRewind_Click);
            // 
            // lblColorBefore
            // 
            this.lblColorBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorBefore.Location = new System.Drawing.Point(140, 3);
            this.lblColorBefore.Name = "lblColorBefore";
            this.lblColorBefore.Size = new System.Drawing.Size(100, 23);
            this.lblColorBefore.TabIndex = 10;
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(143, 3);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 23);
            this.lblColor.TabIndex = 10;
            // 
            // lblColorAfter
            // 
            this.lblColorAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorAfter.Location = new System.Drawing.Point(143, 3);
            this.lblColorAfter.Name = "lblColorAfter";
            this.lblColorAfter.Size = new System.Drawing.Size(100, 23);
            this.lblColorAfter.TabIndex = 10;
            // 
            // btnFoundErrors
            // 
            this.btnFoundErrors.Location = new System.Drawing.Point(626, 9);
            this.btnFoundErrors.Name = "btnFoundErrors";
            this.btnFoundErrors.Size = new System.Drawing.Size(115, 20);
            this.btnFoundErrors.TabIndex = 11;
            this.btnFoundErrors.Text = "btnFoundErrors";
            this.btnFoundErrors.UseVisualStyleBackColor = true;
            this.btnFoundErrors.Click += new System.EventHandler(this.BtnFoundErrors_Click);
            // 
            // btnNextError
            // 
            this.btnNextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextError.Location = new System.Drawing.Point(582, 47);
            this.btnNextError.Name = "btnNextError";
            this.btnNextError.Size = new System.Drawing.Size(75, 23);
            this.btnNextError.TabIndex = 9;
            this.btnNextError.Text = ">";
            this.btnNextError.UseVisualStyleBackColor = true;
            this.btnNextError.Click += new System.EventHandler(this.BtnNextError_Click);
            // 
            // btnRewindError
            // 
            this.btnRewindError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewindError.Location = new System.Drawing.Point(105, 47);
            this.btnRewindError.Name = "btnRewindError";
            this.btnRewindError.Size = new System.Drawing.Size(75, 23);
            this.btnRewindError.TabIndex = 9;
            this.btnRewindError.Text = "<";
            this.btnRewindError.UseVisualStyleBackColor = true;
            this.btnRewindError.Click += new System.EventHandler(this.BtnRewindError_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(24, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GoToFirst_Click);
            // 
            // UpDownSecondsError
            // 
            this.UpDownSecondsError.Location = new System.Drawing.Point(145, 14);
            this.UpDownSecondsError.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDownSecondsError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownSecondsError.Name = "UpDownSecondsError";
            this.UpDownSecondsError.Size = new System.Drawing.Size(99, 20);
            this.UpDownSecondsError.TabIndex = 12;
            this.UpDownSecondsError.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDownSecondsError.ValueChanged += new System.EventHandler(this.UpDownSecondsError_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Erreur entre Debut et Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "secondes";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(666, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GoToLast_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Go to ...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GoTo_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.DetectUrls = false;
            this.richTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(3, 83);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(240, 63);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.DetectUrls = false;
            this.richTextBoxBefore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBefore.Location = new System.Drawing.Point(3, 83);
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            this.richTextBoxBefore.Size = new System.Drawing.Size(237, 63);
            this.richTextBoxBefore.TabIndex = 14;
            this.richTextBoxBefore.Text = "";
            this.richTextBoxBefore.WordWrap = false;
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.DetectUrls = false;
            this.richTextBoxAfter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAfter.Location = new System.Drawing.Point(3, 83);
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            this.richTextBoxAfter.Size = new System.Drawing.Size(240, 63);
            this.richTextBoxAfter.TabIndex = 14;
            this.richTextBoxAfter.Text = "";
            this.richTextBoxAfter.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxLine);
            this.groupBox1.Controls.Add(this.numericUpDownGoTo);
            this.groupBox1.Controls.Add(this.btnRewind);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // numericUpDownGoTo
            // 
            this.numericUpDownGoTo.Location = new System.Drawing.Point(367, 19);
            this.numericUpDownGoTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGoTo.Name = "numericUpDownGoTo";
            this.numericUpDownGoTo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGoTo.TabIndex = 10;
            this.numericUpDownGoTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNextError);
            this.groupBox2.Controls.Add(this.btnFirstError);
            this.groupBox2.Controls.Add(this.btnRewindError);
            this.groupBox2.Controls.Add(this.btnFoundErrors);
            this.groupBox2.Controls.Add(this.UpDownSecondsError);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 80);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error Navigation";
            // 
            // panelBefore
            // 
            this.panelBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBefore.Controls.Add(this.richTextBoxBefore);
            this.panelBefore.Controls.Add(this.lblNumeroLigneBefore);
            this.panelBefore.Controls.Add(this.label19);
            this.panelBefore.Controls.Add(this.lblTempsDebutBefore);
            this.panelBefore.Controls.Add(this.label21);
            this.panelBefore.Controls.Add(this.label22);
            this.panelBefore.Controls.Add(this.lblTempsFinBefore);
            this.panelBefore.Controls.Add(this.lblColorBefore);
            this.panelBefore.Location = new System.Drawing.Point(2, 102);
            this.panelBefore.Name = "panelBefore";
            this.panelBefore.Size = new System.Drawing.Size(250, 160);
            this.panelBefore.TabIndex = 17;
            // 
            // panelCurrent
            // 
            this.panelCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCurrent.Controls.Add(this.richTextBox);
            this.panelCurrent.Controls.Add(this.lblNumeroLigne);
            this.panelCurrent.Controls.Add(this.lblTempsDebut);
            this.panelCurrent.Controls.Add(this.label3);
            this.panelCurrent.Controls.Add(this.label12);
            this.panelCurrent.Controls.Add(this.lblTempsFin);
            this.panelCurrent.Controls.Add(this.lblColor);
            this.panelCurrent.Controls.Add(this.label13);
            this.panelCurrent.Location = new System.Drawing.Point(260, 102);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(250, 160);
            this.panelCurrent.TabIndex = 18;
            // 
            // panelAfter
            // 
            this.panelAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAfter.Controls.Add(this.richTextBoxAfter);
            this.panelAfter.Controls.Add(this.lblNumeroLigneAfter);
            this.panelAfter.Controls.Add(this.label8);
            this.panelAfter.Controls.Add(this.lblTempsDebutAfter);
            this.panelAfter.Controls.Add(this.label15);
            this.panelAfter.Controls.Add(this.lblColorAfter);
            this.panelAfter.Controls.Add(this.label16);
            this.panelAfter.Controls.Add(this.lblTempsFinAfter);
            this.panelAfter.Location = new System.Drawing.Point(517, 102);
            this.panelAfter.Name = "panelAfter";
            this.panelAfter.Size = new System.Drawing.Size(250, 160);
            this.panelAfter.TabIndex = 19;
            // 
            // lblMaxLine
            // 
            this.lblMaxLine.AutoSize = true;
            this.lblMaxLine.Location = new System.Drawing.Point(493, 21);
            this.lblMaxLine.Name = "lblMaxLine";
            this.lblMaxLine.Size = new System.Drawing.Size(27, 13);
            this.lblMaxLine.TabIndex = 11;
            this.lblMaxLine.Text = "/ ??";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 268);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 183);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Navigation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Correction Option";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelAfter);
            this.Controls.Add(this.panelCurrent);
            this.Controls.Add(this.panelBefore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Work With Subtitle (SRT)";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSecondsError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoTo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelBefore.ResumeLayout(false);
            this.panelBefore.PerformLayout();
            this.panelCurrent.ResumeLayout(false);
            this.panelCurrent.PerformLayout();
            this.panelAfter.ResumeLayout(false);
            this.panelAfter.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFirstError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNumeroLigne;
        private System.Windows.Forms.Label lblTempsDebut;
        private System.Windows.Forms.Label lblTempsFin;
        private System.Windows.Forms.Label lblNumeroLigneAfter;
        private System.Windows.Forms.Label lblTempsDebutAfter;
        private System.Windows.Forms.Label lblTempsFinAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNumeroLigneBefore;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTempsDebutBefore;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblTempsFinBefore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Label lblColorBefore;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorAfter;
        private System.Windows.Forms.Button btnFoundErrors;
        private System.Windows.Forms.Button btnNextError;
        private System.Windows.Forms.Button btnRewindError;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown UpDownSecondsError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.RichTextBox richTextBoxBefore;
        private System.Windows.Forms.RichTextBox richTextBoxAfter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownGoTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelBefore;
        private System.Windows.Forms.Panel panelCurrent;
        private System.Windows.Forms.Panel panelAfter;
        private System.Windows.Forms.Label lblMaxLine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

