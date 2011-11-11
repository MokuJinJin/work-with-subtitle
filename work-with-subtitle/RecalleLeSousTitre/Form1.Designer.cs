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
            this.lblTexte = new System.Windows.Forms.Label();
            this.lblNumeroLigneAfter = new System.Windows.Forms.Label();
            this.lblTempsDebutAfter = new System.Windows.Forms.Label();
            this.lblTempsFinAfter = new System.Windows.Forms.Label();
            this.lblTexteAfter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNumeroLigneBefore = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTempsDebutBefore = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblTempsFinBefore = new System.Windows.Forms.Label();
            this.lblTexteBefore = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSecondsError)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 12);
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
            this.textBox1.Size = new System.Drawing.Size(846, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Charger tout le fichier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Charger_Click);
            // 
            // btnFirstError
            // 
            this.btnFirstError.Location = new System.Drawing.Point(391, 283);
            this.btnFirstError.Name = "btnFirstError";
            this.btnFirstError.Size = new System.Drawing.Size(99, 23);
            this.btnFirstError.TabIndex = 3;
            this.btnFirstError.Text = "Go to 1st Error";
            this.btnFirstError.UseVisualStyleBackColor = true;
            this.btnFirstError.Click += new System.EventHandler(this.BtnFirstError_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(864, 457);
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
            this.lblNumeroLigne.Location = new System.Drawing.Point(452, 122);
            this.lblNumeroLigne.Name = "lblNumeroLigne";
            this.lblNumeroLigne.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigne.TabIndex = 5;
            this.lblNumeroLigne.Text = "label1";
            // 
            // lblTempsDebut
            // 
            this.lblTempsDebut.AutoSize = true;
            this.lblTempsDebut.Location = new System.Drawing.Point(452, 145);
            this.lblTempsDebut.Name = "lblTempsDebut";
            this.lblTempsDebut.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebut.TabIndex = 6;
            this.lblTempsDebut.Text = "label2";
            // 
            // lblTempsFin
            // 
            this.lblTempsFin.AutoSize = true;
            this.lblTempsFin.Location = new System.Drawing.Point(452, 168);
            this.lblTempsFin.Name = "lblTempsFin";
            this.lblTempsFin.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFin.TabIndex = 6;
            this.lblTempsFin.Text = "label4";
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Location = new System.Drawing.Point(452, 191);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(35, 13);
            this.lblTexte.TabIndex = 6;
            this.lblTexte.Text = "label5";
            // 
            // lblNumeroLigneAfter
            // 
            this.lblNumeroLigneAfter.AutoSize = true;
            this.lblNumeroLigneAfter.Location = new System.Drawing.Point(756, 122);
            this.lblNumeroLigneAfter.Name = "lblNumeroLigneAfter";
            this.lblNumeroLigneAfter.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigneAfter.TabIndex = 5;
            this.lblNumeroLigneAfter.Text = "label1";
            // 
            // lblTempsDebutAfter
            // 
            this.lblTempsDebutAfter.AutoSize = true;
            this.lblTempsDebutAfter.Location = new System.Drawing.Point(756, 145);
            this.lblTempsDebutAfter.Name = "lblTempsDebutAfter";
            this.lblTempsDebutAfter.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebutAfter.TabIndex = 6;
            this.lblTempsDebutAfter.Text = "label2";
            // 
            // lblTempsFinAfter
            // 
            this.lblTempsFinAfter.AutoSize = true;
            this.lblTempsFinAfter.Location = new System.Drawing.Point(756, 168);
            this.lblTempsFinAfter.Name = "lblTempsFinAfter";
            this.lblTempsFinAfter.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFinAfter.TabIndex = 6;
            this.lblTempsFinAfter.Text = "label4";
            // 
            // lblTexteAfter
            // 
            this.lblTexteAfter.AutoSize = true;
            this.lblTexteAfter.Location = new System.Drawing.Point(756, 191);
            this.lblTexteAfter.Name = "lblTexteAfter";
            this.lblTexteAfter.Size = new System.Drawing.Size(35, 13);
            this.lblTexteAfter.TabIndex = 6;
            this.lblTexteAfter.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro ligne";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Temps début";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(384, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Temp Fin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Texte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Numéro ligne";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(681, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Temps début";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(699, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Temp Fin";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(716, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Texte";
            // 
            // lblNumeroLigneBefore
            // 
            this.lblNumeroLigneBefore.AutoSize = true;
            this.lblNumeroLigneBefore.Location = new System.Drawing.Point(107, 122);
            this.lblNumeroLigneBefore.Name = "lblNumeroLigneBefore";
            this.lblNumeroLigneBefore.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroLigneBefore.TabIndex = 5;
            this.lblNumeroLigneBefore.Text = "label1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Numéro ligne";
            // 
            // lblTempsDebutBefore
            // 
            this.lblTempsDebutBefore.AutoSize = true;
            this.lblTempsDebutBefore.Location = new System.Drawing.Point(107, 145);
            this.lblTempsDebutBefore.Name = "lblTempsDebutBefore";
            this.lblTempsDebutBefore.Size = new System.Drawing.Size(35, 13);
            this.lblTempsDebutBefore.TabIndex = 6;
            this.lblTempsDebutBefore.Text = "label2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Temps début";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Temp Fin";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(67, 191);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Texte";
            // 
            // lblTempsFinBefore
            // 
            this.lblTempsFinBefore.AutoSize = true;
            this.lblTempsFinBefore.Location = new System.Drawing.Point(107, 168);
            this.lblTempsFinBefore.Name = "lblTempsFinBefore";
            this.lblTempsFinBefore.Size = new System.Drawing.Size(35, 13);
            this.lblTempsFinBefore.TabIndex = 6;
            this.lblTempsFinBefore.Text = "label4";
            // 
            // lblTexteBefore
            // 
            this.lblTexteBefore.AutoSize = true;
            this.lblTexteBefore.Location = new System.Drawing.Point(107, 191);
            this.lblTexteBefore.Name = "lblTexteBefore";
            this.lblTexteBefore.Size = new System.Drawing.Size(35, 13);
            this.lblTexteBefore.TabIndex = 6;
            this.lblTexteBefore.Text = "label5";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(496, 240);
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
            this.btnRewind.Location = new System.Drawing.Point(310, 240);
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
            this.lblColorBefore.Location = new System.Drawing.Point(42, 89);
            this.lblColorBefore.Name = "lblColorBefore";
            this.lblColorBefore.Size = new System.Drawing.Size(100, 23);
            this.lblColorBefore.TabIndex = 10;
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(387, 89);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 23);
            this.lblColor.TabIndex = 10;
            // 
            // lblColorAfter
            // 
            this.lblColorAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorAfter.Location = new System.Drawing.Point(691, 89);
            this.lblColorAfter.Name = "lblColorAfter";
            this.lblColorAfter.Size = new System.Drawing.Size(100, 23);
            this.lblColorAfter.TabIndex = 10;
            // 
            // btnFoundErrors
            // 
            this.btnFoundErrors.Location = new System.Drawing.Point(200, 283);
            this.btnFoundErrors.Name = "btnFoundErrors";
            this.btnFoundErrors.Size = new System.Drawing.Size(104, 23);
            this.btnFoundErrors.TabIndex = 11;
            this.btnFoundErrors.Text = "btnFoundErrors";
            this.btnFoundErrors.UseVisualStyleBackColor = true;
            this.btnFoundErrors.Click += new System.EventHandler(this.BtnFoundErrors_Click);
            // 
            // btnNextError
            // 
            this.btnNextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextError.Location = new System.Drawing.Point(496, 283);
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
            this.btnRewindError.Location = new System.Drawing.Point(310, 283);
            this.btnRewindError.Name = "btnRewindError";
            this.btnRewindError.Size = new System.Drawing.Size(75, 23);
            this.btnRewindError.TabIndex = 9;
            this.btnRewindError.Text = "<";
            this.btnRewindError.UseVisualStyleBackColor = true;
            this.btnRewindError.Click += new System.EventHandler(this.BtnRewindError_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Go to 1st";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.First_Click);
            // 
            // UpDownSecondsError
            // 
            this.UpDownSecondsError.Location = new System.Drawing.Point(391, 312);
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
            this.label1.Location = new System.Drawing.Point(256, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Erreur entre Debut et Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "secondes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownSecondsError);
            this.Controls.Add(this.btnFoundErrors);
            this.Controls.Add(this.lblColorAfter);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblColorBefore);
            this.Controls.Add(this.btnRewindError);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.btnNextError);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTexteBefore);
            this.Controls.Add(this.lblTexteAfter);
            this.Controls.Add(this.lblTempsFinBefore);
            this.Controls.Add(this.lblTempsFinAfter);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTempsFin);
            this.Controls.Add(this.lblTempsDebutBefore);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTempsDebutAfter);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblNumeroLigneBefore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNumeroLigneAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTempsDebut);
            this.Controls.Add(this.lblNumeroLigne);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnFirstError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSecondsError)).EndInit();
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
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Label lblNumeroLigneAfter;
        private System.Windows.Forms.Label lblTempsDebutAfter;
        private System.Windows.Forms.Label lblTempsFinAfter;
        private System.Windows.Forms.Label lblTexteAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNumeroLigneBefore;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTempsDebutBefore;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTempsFinBefore;
        private System.Windows.Forms.Label lblTexteBefore;
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
    }
}

