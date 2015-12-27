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
        String path = @"C:\Users\rvank\Dropbox\Rest\Bijbelboeken";
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
    }
}
