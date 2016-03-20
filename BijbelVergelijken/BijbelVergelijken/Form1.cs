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

namespace BijbelVergelijken
{
    public partial class Form1 : Form
    {
        String[] books = { "Genesis", "Exodus", "Leviticus", "Numeri", "Deuteronomium", "Jozua", "Rechters", "Ruth", "1 Samuel", "2 Samuel", "1 Koningen", "2 Koningen", "1 Kronieken", "2 Kronieken", "Ezra", "Nehemia", "Ester", "Job", "Psalmen", "Spreuken", "Prediker", "Hooglied", "Jesaja", "Jeremia", "Klaagliederen", "Ezechiël", "Daniël", "Hosea", "Joël", "Amos", "Obadja", "Jona", "Micha", "Nahum", "Habakuk", "Sefanja", "Haggai", "Zacharia", "Maleachi", "Matteüs", "Marcus", "Lucas", "Johannes", "Handelingen", "Romeinen", "1 Korintiërs", "2 Korintiërs", "Galaten", "Efeziërs", "Filippenzen", "Kolossenzen", "1 Tessalonicenzen", "2 Tessalonicenzen", "1 Timoteüs", "2 Timoteüs", "Titus", "Filemon", "Hebreeërs", "Jakobus", "1 Petrus", "2 Petrus", "1 Johannes", "2 Johannes", "3 Johannes", "Judas", "Openbaring" };
        String[] chapters = { "50", "40", "27", "36", "34", "24", "21", "4", "31", "24", "22", "25", "29", "36", "10", "13", "10", "42", "150", "31", "12", "8", "66", "52", "5", "48", "12", "14", "4", "9", "1", "4", "7", "3", "3", "3", "2", "14", "3", "28", "16", "24", "21", "28", "16", "16", "13", "6", "6", "4", "4", "5", "3", "6", "4", "3", "1", "13", "5", "5", "3", "5", "1", "1", "1", "22" };
        String[] versions = { "Amplified Bible", "Biblia Dios Habla Hoy (derde editie)", "Biblia Hebraica Stuttgartensia", "Biebel in de Twentse Sproake", "Biebel in t Grunnegers", "Bijbel in Gewone Taal", "Contemporary English Version, Second Edition", "De Nieuwe Bijbelvertaling", "English Standard Version", "Good News Translation (Today's English Version, Second Edition)", "Groot Nieuws Bijbel (herziene editie 1996)", "Herziene Statenvertaling", "King James Version", "NBG-vertaling 1951", "New American Standard Bible", "Nije Fryske Bibeloersetting", "Novum Testamentum Graece", "Statenvertaling (editie 1977)", "Statenvertaling (Jongbloed-editie)", "Statenvertaling 1637", "The Message", "Willibrordvertaling (editie 2012)" };
        String path = @"bijbel\";
        public Form1()
        {
            InitializeComponent();
        }
    
        private void cbBoek1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chapter = getChapterByBook(cbBoek.SelectedItem.ToString());
            fillChapterList(chapter, cbHoofdstuk);
        }

        private void fillChapterList(int chapter, ComboBox cbHoofdstuk)
        {
            cbHoofdstuk.Items.Clear();
            for (int i=0;i<chapter;i++)
            {
                cbHoofdstuk.Items.Add(i+1);
            }
            cbHoofdstuk.Text = "0";
        }

        private int getChapterByBook(String book)
        {
            int index = Array.IndexOf<String>(books, book);
            if (index != -1)
            {
                return Int32.Parse(chapters[index]);
            }
            return -1;
        }

        private void cbHoofdstuk1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String boekPath = getBoekPath();
            String pathC1 = path + "\\" + cbVertaling1.SelectedItem.ToString() + boekPath;
            String pathC2 = path + "\\" + cbVertaling2.SelectedItem.ToString() + boekPath;
            loadBijbel(pathC1, bijbel1);
            loadBijbel(pathC2, bijbel2);
        }

        private void loadBijbel(String path, TextBox bijbel)
        {
            if (File.Exists(path)){
                String text = System.IO.File.ReadAllText(path,Encoding.Default);
                bijbel.Text = text;
            }
            else{
                bijbel.Text = "De vertaling / bijbelboek / hoofdstuk kan niet gevonden worden";
            }
        }

        private void cbVertaling1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoek.SelectedItem != null && cbBoek.SelectedItem.ToString() != "" && cbHoofdstuk.SelectedItem != null && cbHoofdstuk.SelectedItem.ToString() != "0")
            {
                loadBijbel(path + "\\" + cbVertaling1.SelectedItem.ToString() + getBoekPath(), bijbel1);
            }
        }

        private void cbVertaling2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoek.SelectedItem!=null && cbBoek.SelectedItem.ToString() != "" && cbHoofdstuk.SelectedItem!=null && cbHoofdstuk.SelectedItem.ToString() != "0")
            {
                loadBijbel(path + "\\" + cbVertaling2.SelectedItem.ToString() + getBoekPath(), bijbel2);
            }
        }

        private String getBoekPath()
        {
            return "\\" + cbBoek.SelectedItem.ToString() + " " + cbHoofdstuk.SelectedItem.ToString() + ".txt";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            label3.Text = "Locatie: "+fbd.SelectedPath;
            // Compose a string that consists of three lines.
            string lines = "path="+ fbd.SelectedPath;

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("config.txt");
            file.WriteLine(lines);

            file.Close();
            getVertalingenFromFile(fbd.SelectedPath);


        }
        private void getVertalingenFromFile(String path)
        {
            clearData();
            String[] beschikbareVertalingen = new String[versions.Length];
            int i = 0;
            if (Directory.Exists(path))
            {
                this.path = path;
                foreach (string s in Directory.GetDirectories(path))
                {
                    if (Array.FindAll(versions, st => st.Equals(s.Remove(0, path.Length + 1))).Length > 0)
                    {
                        beschikbareVertalingen[i] = s.Remove(0, path.Length + 1);
                        i++;
                    }
                }
                loadCb(beschikbareVertalingen);
            }
        }

        private void clearData()
        {
            cbVertaling1.Items.Clear();
            cbVertaling2.Items.Clear();
            bijbel1.Text = "";
            bijbel2.Text = "";
            cbHoofdstuk.Text = "0";
        }

        private void loadCb(String[] beschikbareVertalingen)
        {
            clearData();
            foreach (String vert in beschikbareVertalingen)
            {
                cbVertaling1.Items.Add(vert);
                // todo uit config halen?
                if (vert.Equals("De Nieuwe Bijbelvertaling"))
                {
                    cbVertaling1.Text = "De Nieuwe Bijbelvertaling";
                }
                cbVertaling2.Items.Add(vert);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"config.txt"))
            {
                // cofig uitlezen
                string[] lines = System.IO.File.ReadAllLines(@"config.txt");

                foreach (string line in lines)
                {
                    String[] config = line.Split('=');
                    if (config[0].Equals("path"))
                    {
                        label3.Text = "Locatie: " + config[1];
                        getVertalingenFromFile(config[1]);
                    }
                }
            }
        }
    }
}
