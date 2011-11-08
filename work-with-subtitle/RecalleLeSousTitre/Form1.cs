using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RecalleLeSousTitre
{
    public partial class Form1 : Form
    {
        public string file = string.Empty;
        List<LigneSousTitre> SSTitre = new List<LigneSousTitre>();
        private Controler _controler = new Controler();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = @"C:\CSI8x01.srt";
            file = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                textBox1.Text = file;
            }
        }

        private void Charger_Click(object sender, EventArgs e)
        {
            _controler.ReadFile(file);
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetFirst();

            AfficheLignes(lignes);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetNext();
            AfficheLignes(lignes);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetRewind();
            AfficheLignes(lignes);
        }

        private void btnFirstError_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetFirstError();
            AfficheLignes(lignes);
        }

        private void AfficheLignes(Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes)
        {
            lblNumeroLigneBefore.Text = lignes.Item1.numero.ToString();
            lblTempsDebutBefore.Text = lignes.Item1.TempsDebut.ToString();
            lblTempsFinBefore.Text = lignes.Item1.TempsFin.ToString();
            lblTexteBefore.Text = string.Empty;
            lignes.Item1.soustitre.ForEach(s => lblTexteBefore.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColorBefore.BackColor = Utils.DiffDebutFinColor(lignes.Item1, _controler.SecondsError);

            lblNumeroLigne.Text = lignes.Item2.numero.ToString();
            lblTempsDebut.Text = lignes.Item2.TempsDebut.ToString();
            lblTempsFin.Text = lignes.Item2.TempsFin.ToString();
            lblTexte.Text = string.Empty; 
            lignes.Item2.soustitre.ForEach(s => lblTexte.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColor.BackColor = Utils.DiffDebutFinColor(lignes.Item2, _controler.SecondsError);

            lblNumeroLigneAfter.Text = lignes.Item3.numero.ToString();
            lblTempsDebutAfter.Text = lignes.Item3.TempsDebut.ToString();
            lblTempsFinAfter.Text = lignes.Item3.TempsFin.ToString();
            lblTexteAfter.Text = string.Empty;
            lignes.Item3.soustitre.ForEach(s => lblTexteAfter.Text += string.Format("{0}{1}", s, Environment.NewLine));
            lblColorAfter.BackColor = Utils.DiffDebutFinColor(lignes.Item3, _controler.SecondsError);
        }

        private void save_Click(object sender, EventArgs e)
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

        private void btnFoundErrors_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controler.FoundErrors().ToString());
        }

        private void btnRewindError_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetRewindError();
            AfficheLignes(lignes);
        }

        private void btnNextError_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetNextError();
            AfficheLignes(lignes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> lignes = _controler.GetFirst();
            AfficheLignes(lignes);
        }

        private void UpDownSecondsError_ValueChanged(object sender, EventArgs e)
        {
            _controler.SecondsError = int.Parse(UpDownSecondsError.Value.ToString());
        }

        
    }
}
