
namespace SparaLasaKontakt_ovn4_2
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
            this.btnSparaSom = new System.Windows.Forms.Button();
            this.btnÖppna = new System.Windows.Forms.Button();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.dlgSpraraFil = new System.Windows.Forms.SaveFileDialog();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.lbxKontakter = new System.Windows.Forms.ListBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSparaSom
            // 
            this.btnSparaSom.Location = new System.Drawing.Point(162, 191);
            this.btnSparaSom.Name = "btnSparaSom";
            this.btnSparaSom.Size = new System.Drawing.Size(114, 36);
            this.btnSparaSom.TabIndex = 0;
            this.btnSparaSom.Text = "Spara som...";
            this.btnSparaSom.UseVisualStyleBackColor = true;
            this.btnSparaSom.Click += new System.EventHandler(this.btnSparaSom_Click);
            // 
            // btnÖppna
            // 
            this.btnÖppna.Location = new System.Drawing.Point(33, 191);
            this.btnÖppna.Name = "btnÖppna";
            this.btnÖppna.Size = new System.Drawing.Size(106, 36);
            this.btnÖppna.TabIndex = 1;
            this.btnÖppna.Text = "Öppna";
            this.btnÖppna.UseVisualStyleBackColor = true;
            this.btnÖppna.Click += new System.EventHandler(this.btnÖppna_Click);
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(12, 24);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(64, 17);
            this.lblFörnamn.TabIndex = 2;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(135, 21);
            this.tbxFörnamn.Multiline = true;
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(162, 31);
            this.tbxFörnamn.TabIndex = 6;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(135, 58);
            this.tbxEfternamn.Multiline = true;
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(162, 31);
            this.tbxEfternamn.TabIndex = 8;
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(12, 61);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(73, 17);
            this.lblEfternamn.TabIndex = 7;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(135, 95);
            this.tbxEpost.Multiline = true;
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(162, 31);
            this.tbxEpost.TabIndex = 10;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(12, 98);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(49, 17);
            this.lblEpost.TabIndex = 9;
            this.lblEpost.Text = "E-post";
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(135, 132);
            this.tbxTelefonnummer.Multiline = true;
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(162, 31);
            this.tbxTelefonnummer.TabIndex = 12;
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Location = new System.Drawing.Point(12, 135);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(107, 17);
            this.lblTelefonnummer.TabIndex = 11;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // lbxKontakter
            // 
            this.lbxKontakter.FormattingEnabled = true;
            this.lbxKontakter.ItemHeight = 16;
            this.lbxKontakter.Location = new System.Drawing.Point(323, 21);
            this.lbxKontakter.Name = "lbxKontakter";
            this.lbxKontakter.Size = new System.Drawing.Size(201, 148);
            this.lbxKontakter.TabIndex = 13;
            this.lbxKontakter.SelectedIndexChanged += new System.EventHandler(this.lbxKontakter_SelectedIndexChanged_1);
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(323, 191);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(100, 36);
            this.btnLäggTill.TabIndex = 14;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click_1);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(429, 191);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(95, 36);
            this.btnTaBort.TabIndex = 15;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 239);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.lbxKontakter);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.lblTelefonnummer);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.lblFörnamn);
            this.Controls.Add(this.btnÖppna);
            this.Controls.Add(this.btnSparaSom);
            this.Name = "Form1";
            this.Text = "En kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSparaSom;
        private System.Windows.Forms.Button btnÖppna;
        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.SaveFileDialog dlgSpraraFil;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.ListBox lbxKontakter;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTaBort;
    }
}

