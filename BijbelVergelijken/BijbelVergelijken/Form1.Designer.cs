namespace BijbelVergelijken
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
            this.gb_opties = new System.Windows.Forms.GroupBox();
            this.cbHoofdstuk = new System.Windows.Forms.ComboBox();
            this.cbBoek = new System.Windows.Forms.ComboBox();
            this.cbVertaling2 = new System.Windows.Forms.ComboBox();
            this.cbVertaling1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bijbel1 = new System.Windows.Forms.TextBox();
            this.bijbel2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_opties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_opties
            // 
            this.gb_opties.Controls.Add(this.cbHoofdstuk);
            this.gb_opties.Controls.Add(this.cbBoek);
            this.gb_opties.Controls.Add(this.cbVertaling2);
            this.gb_opties.Controls.Add(this.cbVertaling1);
            this.gb_opties.Controls.Add(this.label2);
            this.gb_opties.Controls.Add(this.label1);
            this.gb_opties.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_opties.Location = new System.Drawing.Point(0, 0);
            this.gb_opties.Name = "gb_opties";
            this.gb_opties.Size = new System.Drawing.Size(996, 37);
            this.gb_opties.TabIndex = 0;
            this.gb_opties.TabStop = false;
            this.gb_opties.Text = "Opties";
            // 
            // cbHoofdstuk
            // 
            this.cbHoofdstuk.FormattingEnabled = true;
            this.cbHoofdstuk.Location = new System.Drawing.Point(627, 11);
            this.cbHoofdstuk.Name = "cbHoofdstuk";
            this.cbHoofdstuk.Size = new System.Drawing.Size(47, 21);
            this.cbHoofdstuk.TabIndex = 3;
            this.cbHoofdstuk.Text = "0";
            this.cbHoofdstuk.SelectedIndexChanged += new System.EventHandler(this.cbHoofdstuk1_SelectedIndexChanged);
            // 
            // cbBoek
            // 
            this.cbBoek.FormattingEnabled = true;
            this.cbBoek.Items.AddRange(new object[] {
            "Genesis",
            "Exodus",
            "Leviticus",
            "Numeri",
            "Deuteronomium",
            "Jozua",
            "Rechters",
            "Ruth",
            "1-Samuel",
            "2-Samuel",
            "1-Koningen",
            "2-Koningen",
            "1-Kronieken",
            "2-Kronieken",
            "Ezra",
            "Nehemia",
            "Ester",
            "Job",
            "Psalmen",
            "Spreuken",
            "Prediker",
            "Hooglied",
            "Jesaja",
            "Jeremia",
            "Klaagliederen",
            "Ezechiël",
            "Daniël",
            "Hosea",
            "Joël",
            "Amos",
            "Obadja",
            "Jona",
            "Micha",
            "Nahum",
            "Habakuk",
            "Sefanja",
            "Haggai",
            "Zacharia",
            "Maleachi",
            "Matteüs",
            "Marcus",
            "Lucas",
            "Johannes",
            "Handelingen",
            "Romeinen",
            "1-Korintiërs",
            "2-Korintiërs",
            "Galaten",
            "Efeziërs",
            "Filippenzen",
            "Kolossenzen",
            "1-Tessalonicenzen",
            "2-Tessalonicenzen",
            "1-Timoteüs",
            "2-Timoteüs",
            "Titus",
            "Filemon",
            "Hebreeërs",
            "Jakobus",
            "1-Petrus",
            "2-Petrus",
            "1-Johannes",
            "2-Johannes",
            "3-Johannes",
            "Judas",
            "Openbaring"});
            this.cbBoek.Location = new System.Drawing.Point(500, 11);
            this.cbBoek.Name = "cbBoek";
            this.cbBoek.Size = new System.Drawing.Size(121, 21);
            this.cbBoek.TabIndex = 2;
            this.cbBoek.Text = "Boek";
            this.cbBoek.SelectedIndexChanged += new System.EventHandler(this.cbBoek1_SelectedIndexChanged);
            // 
            // cbVertaling2
            // 
            this.cbVertaling2.FormattingEnabled = true;
            this.cbVertaling2.Items.AddRange(new object[] {
            "Amplified Bible",
            "Biblia Dios Habla Hoy (derde editie)",
            "Biebel in de Twentse Sproake",
            "Biebel in t Grunnegers",
            "Bijbel in Gewone Taal",
            "Contemporary English Version, Second Edition",
            "De Nieuwe Bijbelvertaling",
            "Good News Translation (Today\'s English Version, Second Edition)",
            "Groot Nieuws Bijbel (herziene editie 1996)",
            "Herziene Statenvertaling",
            "Jongerenbijbel",
            "NBG-vertaling 1951",
            "New American Standard Bible",
            "Nije Fryske Bibeloersetting",
            "Statenvertaling (editie 1977)",
            "Statenvertaling (Jongbloed-editie)",
            "The Message",
            "Willibrordvertaling (editie 2012)"});
            this.cbVertaling2.Location = new System.Drawing.Point(292, 11);
            this.cbVertaling2.Name = "cbVertaling2";
            this.cbVertaling2.Size = new System.Drawing.Size(159, 21);
            this.cbVertaling2.TabIndex = 1;
            this.cbVertaling2.SelectedIndexChanged += new System.EventHandler(this.cbVertaling2_SelectedIndexChanged);
            // 
            // cbVertaling1
            // 
            this.cbVertaling1.DisplayMember = "Jongerenbijbel";
            this.cbVertaling1.FormattingEnabled = true;
            this.cbVertaling1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbVertaling1.Items.AddRange(new object[] {
            "Amplified Bible",
            "Biblia Dios Habla Hoy (derde editie)",
            "Biebel in de Twentse Sproake",
            "Biebel in t Grunnegers",
            "Bijbel in Gewone Taal",
            "Contemporary English Version, Second Edition",
            "De Nieuwe Bijbelvertaling",
            "Good News Translation (Today\'s English Version, Second Edition)",
            "Groot Nieuws Bijbel (herziene editie 1996)",
            "Herziene Statenvertaling",
            "Jongerenbijbel",
            "NBG-vertaling 1951",
            "New American Standard Bible",
            "Nije Fryske Bibeloersetting",
            "Statenvertaling (editie 1977)",
            "Statenvertaling (Jongbloed-editie)",
            "The Message",
            "Willibrordvertaling (editie 2012)"});
            this.cbVertaling1.Location = new System.Drawing.Point(66, 12);
            this.cbVertaling1.Name = "cbVertaling1";
            this.cbVertaling1.Size = new System.Drawing.Size(160, 21);
            this.cbVertaling1.TabIndex = 1;
            this.cbVertaling1.Text = "Jongerenbijbel";
            this.cbVertaling1.SelectedIndexChanged += new System.EventHandler(this.cbVertaling1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vertaling2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertaling1";
            // 
            // bijbel1
            // 
            this.bijbel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bijbel1.Location = new System.Drawing.Point(6, 6);
            this.bijbel1.Multiline = true;
            this.bijbel1.Name = "bijbel1";
            this.bijbel1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bijbel1.Size = new System.Drawing.Size(488, 370);
            this.bijbel1.TabIndex = 1;
            // 
            // bijbel2
            // 
            this.bijbel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bijbel2.Location = new System.Drawing.Point(500, 6);
            this.bijbel2.Multiline = true;
            this.bijbel2.Name = "bijbel2";
            this.bijbel2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bijbel2.Size = new System.Drawing.Size(490, 370);
            this.bijbel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bijbel1);
            this.groupBox1.Controls.Add(this.bijbel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_opties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_opties.ResumeLayout(false);
            this.gb_opties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_opties;
        private System.Windows.Forms.ComboBox cbHoofdstuk;
        private System.Windows.Forms.ComboBox cbBoek;
        private System.Windows.Forms.ComboBox cbVertaling2;
        private System.Windows.Forms.ComboBox cbVertaling1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bijbel1;
        private System.Windows.Forms.TextBox bijbel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

