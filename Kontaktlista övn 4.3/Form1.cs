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

namespace SparaLasaKontakt_ovn4_2
{
    public partial class Form1 : Form
    {
        class Kontakt
        {
            public Kontakt(string förnamn, string efternamn, string epost, string telefonnr)
            {
                this.Förnamn = förnamn;
                this.Efternamn = efternamn;
                this.Epost = epost;
                this.Telefonnr = telefonnr;
            }

            public string Förnamn { get; set; }

            public string Efternamn { get; set; }

            public string Epost { get; set; }

            public string Telefonnr { get; set; }

            //Returnerar kontaktens för- och efternamn
            public override string ToString()
            {
                return Förnamn + " " + Efternamn;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSparaSom_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgSpraraFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //Öppna ström
                FileStream utStröm = new FileStream(dlgSpraraFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                //Skapa skrivare
                StreamWriter skrivare = new StreamWriter(utStröm);

                // Skriv en kontakt i taget
                foreach (Kontakt k in lbxKontakter.Items)
                {
                    skrivare.WriteLine(k.Förnamn);
                    skrivare.WriteLine(k.Efternamn);
                    skrivare.WriteLine(k.Epost);
                    skrivare.WriteLine(k.Telefonnr);
                }

                //Stäng filen 
                skrivare.Dispose();
            }
        }

        private void btnÖppna_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn för öppning.
            DialogResult resultat = dlgÖppnaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //Rensa listboxen
                this.lbxKontakter.Items.Clear();

                //Öppna ström
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);

                //Skapa skrivare
                StreamReader läsare = new StreamReader(inStröm);

                // Läs en kontakt i teget.
                string förnamn = läsare.ReadLine();
                while (förnamn != null)
                {
                    Kontakt k = new Kontakt(förnamn, läsare.ReadLine(), läsare.ReadLine(), läsare.ReadLine());
                    this.lbxKontakter.Items.Add(k);
                    förnamn = läsare.ReadLine();
                }

                //Stäng filen 
                läsare.Dispose();
            }
        }

        private void btnLäggTill_Click_1(object sender, EventArgs e)
        {
            //Skapa kontakt
            Kontakt kontakt = new Kontakt(this.tbxFörnamn.Text, this.tbxEfternamn.Text, this.tbxEpost.Text, this.tbxTelefonnummer.Text);

            //Lägg till kontakt i listboxen
            this.lbxKontakter.Items.Add(kontakt);
        }

        private void btnTaBort_Click_1(object sender, EventArgs e)
        {
            // Ta bort den valda kontakten
            lbxKontakter.Items.Remove(lbxKontakter.SelectedItem);
        }

        private void lbxKontakter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbxKontakter.SelectedItem != null)
            {
                //Gör ett objekt av den valda kontakten
                Kontakt k = lbxKontakter.SelectedItem as Kontakt;
                //Skriv de olika delarna av kontakten i respektive textbox.
                tbxFörnamn.Text = k.Förnamn;
                tbxEfternamn.Text = k.Efternamn;
                tbxEpost.Text = k.Epost;
                tbxTelefonnummer.Text = k.Telefonnr;
            }
            else
            {
                //Skriv de olika delarana av kontakten i respektive textbox
                tbxFörnamn.Text = "";
                tbxEfternamn.Text = "";
                tbxEpost.Text = "";
                tbxTelefonnummer.Text = "";
            }
        }
    }

}