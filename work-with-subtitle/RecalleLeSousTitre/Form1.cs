//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Zed Byt Corp">
//     Copyright Zed Byt Corp 2010
// </copyright>
//-----------------------------------------------------------------------

namespace RecalleLeSousTitre
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Main form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Loaded file
        /// </summary>
        private string file = string.Empty;

        /// <summary>
        /// UI Controler
        /// </summary>
        private Controler _controler = new Controler();

        /// <summary>
        /// Main form Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = @"C:\CSI8x01.srt";
            file = textBox1.Text;
        }

        /// <summary>
        /// Browse file to load
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">eventArgs</param>
        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                textBox1.Text = file;
            }
        }

        /// <summary>
        /// Load file and read it
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Charger_Click(object sender, EventArgs e)
        {
            _controler.ReadFile(file);
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetFirst();

            AfficheLignes(lignes);
        }

        /// <summary>
        /// Move to next Subtitle
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetNext();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// Rewind to before subtitle
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnRewind_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetRewind();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// Set the current subtitle to the first error
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnFirstError_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetFirstError();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// Method to show the subtitles
        /// </summary>
        /// <param name="lines">Before, after and the current subtitle</param>
        private void AfficheLignes(Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lines)
        {
            lblNumeroLigneBefore.Text = lines.Item1.Numero.ToString();
            lblTempsDebutBefore.Text = lines.Item1.StartTime.ToString();
            lblTempsFinBefore.Text = lines.Item1.EndTime.ToString();
            lblTexteBefore.Text = string.Empty;
            lines.Item1.Text.ForEach(s => lblTexteBefore.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColorBefore.BackColor = Utils.ColorErrorBetweenStartAndEndTime(lines.Item1, _controler.SecondsError);

            lblNumeroLigne.Text = lines.Item2.Numero.ToString();
            lblTempsDebut.Text = lines.Item2.StartTime.ToString();
            lblTempsFin.Text = lines.Item2.EndTime.ToString();
            lblTexte.Text = string.Empty; 
            lines.Item2.Text.ForEach(s => lblTexte.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColor.BackColor = Utils.ColorErrorBetweenStartAndEndTime(lines.Item2, _controler.SecondsError);

            lblNumeroLigneAfter.Text = lines.Item3.Numero.ToString();
            lblTempsDebutAfter.Text = lines.Item3.StartTime.ToString();
            lblTempsFinAfter.Text = lines.Item3.EndTime.ToString();
            lblTexteAfter.Text = string.Empty;
            lines.Item3.Text.ForEach(s => lblTexteAfter.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColorAfter.BackColor = Utils.ColorErrorBetweenStartAndEndTime(lines.Item3, _controler.SecondsError);
        }

        /// <summary>
        /// Write all subtitle lines into a file
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    File.Delete(saveFileDialog1.FileName);
                }

                _controler.SaveFile(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Show the number of errors into the subtitle
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnFoundErrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controler.FoundErrors().ToString());
        }

        /// <summary>
        /// Rewind to before error
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnRewindError_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetRewindError();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// go to the next error
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void BtnNextError_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetNextError();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// Go to the first subtitle
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void GoToFirst_Click(object sender, EventArgs e)
        {
            Tuple<SubtitleLine, SubtitleLine, SubtitleLine> lignes = _controler.GetFirst();
            AfficheLignes(lignes);
        }

        /// <summary>
        /// Change the seocnd between StartTime and EndTime
        /// to be considerated as an error
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void UpDownSecondsError_ValueChanged(object sender, EventArgs e)
        {
            _controler.SecondsError = int.Parse(UpDownSecondsError.Value.ToString());
        }
    }
}
