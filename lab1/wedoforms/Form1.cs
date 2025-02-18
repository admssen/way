using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wedoforms
{
    public partial class Form1 : Form
    {
        private bool tap;
        private bool taptap;
        public Form1()
        {
            setAll();
        }
        public void setAll()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ContextMenuStrip = contextMenuStrip1;
            this.tap = false;
            this.taptap = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { tap = true; } }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { taptap = true; } }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tap && e.Alt && e.KeyCode == Keys.I)
            { setAll(); }
            else if (taptap && e.Alt && e.KeyCode == Keys.X)
            { this.Close(); }
        }
        private void ToolStripMenuItemdI_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) {
                string parsed = textBox1.Text;
                if (parsed.Length > 2)
                {
                    while(parsed.Last() == '0' && parsed.Length>2)
                    { parsed = parsed.Remove(parsed.Length - 1); }
                }
                if (parsed.Length > 0) { if (parsed.Last() == '.') { parsed = parsed.Remove(parsed.Length - 1); } }
                if (parsed != "-") { listBox1.Items.Add(parsed); }
            }
            else { MessageBox.Show("there's nothing"); }
        }

        private void ToolStripMenuItemdII_Click(object sender, EventArgs e)
        { foreach (string s in listBox1.SelectedItems.OfType<string>().ToList()) { listBox1.Items.Remove(s); } }

        private void ToolStripMenuItemdIII_Click(object sender, EventArgs e)
        {
            foreach (string parsed in listBox1.Items.OfType<string>().ToList())
            {
                if (Int32.Parse(parsed.Split('.')[0]) % 2 == 0)
                { listBox2.Items.Add(parsed); }
            }
        }

        private void toolStripMenuItemdIV_Click(object sender, EventArgs e)
        {
            double multi = 1;
            double count = 0;
            string result = "";
            foreach (string parsed in listBox1.Items.OfType<string>().ToList())
            {
                if (double.Parse(parsed) > 0)
                {
                    multi *= double.Parse(parsed) - Int32.Parse(parsed.Split('.')[0]);
                    count++;
                }
            }
            if (count > 0) { result = Math.Pow(multi, 1 / count).ToString(); }
            if (result != "") { listBox2.Items.Add(result); }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {this.Text = "praise the "+comboBox1.SelectedItem.ToString()+"!";}
        private void comboBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string addition = comboBox1.Text.Trim();
                if (!string.IsNullOrEmpty(addition) && !comboBox1.Items.Contains(addition))
                { comboBox1.Items.Add(addition); comboBox1.SelectedIndex = -1; }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#777799");}
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#666688");}
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#555577");}
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#444466");}
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#333355");}
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {this.BackColor = ColorTranslator.FromHtml("#222244");}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool hdle = true;
            string parsed = textBox1.Text.ToString();
            if ((char.IsDigit(e.KeyChar) || e.KeyChar == '-') && string.IsNullOrEmpty(parsed))
            { hdle = false; }
            else if ((char.IsDigit(e.KeyChar) || e.KeyChar=='.' || char.IsControl(e.KeyChar)) && !string.IsNullOrEmpty(parsed))
            {
                char input = e.KeyChar;
                bool dot_used = false;
                bool zero = false;
                int tb1_l = 0;
                foreach (char g in parsed)
                {
                    if (g == '-' && tb1_l == 0) { tb1_l = -1; }
                    if (g == '0' && tb1_l == 0) { zero = true; }
                    if (g == '.') { dot_used = true; zero = false; }
                    tb1_l++;
                }
                switch (input)
                {
                    case '0': if (!zero) { hdle = false; } break;
                    case '.': if (!dot_used && tb1_l>0) { hdle = false; } break;
                    default: hdle = false; break;
                }
            }
            e.Handled = hdle;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void ToolStripMenuItemI_Click(object sender, EventArgs e)
        { if (!string.IsNullOrEmpty(textBox2.Text)) { listBox3.Items.Add(textBox2.Text); } }
        private void ToolStripMenuItemII_Click(object sender, EventArgs e)
        { foreach (string s in listBox3.SelectedItems.OfType<string>().ToList()) { listBox3.Items.Remove(s); } }
        private void ToolStripMenuItemIII_Click(object sender, EventArgs e)
        {
            string lb3_shortest = "nuh";
            int lb3_shortest_l = 0;
            string lb3_longest = "uh";
            int lb3_longest_l = 0;
            foreach (string parsed in listBox3.Items.OfType<string>().ToList())
            {
                int parsed_l = parsed.Length;
                if (lb3_shortest_l == 0)
                { lb3_shortest_l = parsed_l; lb3_shortest = parsed; }
                else if (parsed_l < lb3_shortest_l)
                { lb3_shortest_l = parsed_l; lb3_shortest = parsed; }
                if (lb3_longest_l == 0)
                { lb3_longest_l = parsed_l; lb3_longest = parsed; }
                else if (parsed_l > lb3_longest_l)
                { lb3_longest_l = parsed_l; lb3_longest = parsed; }
            }
            MessageBox.Show(lb3_shortest + " " + lb3_longest);
        }
        private void ToolStripMenuItemIV_Click(object sender, EventArgs e)
        {
            List<int> rating = new List<int>();
            int maxcount = 0;
            int count = 0;
            string result = "";
            foreach (string parsed in listBox3.Items.OfType<string>().ToList()) {
                bool space = false;
                char s = parsed.First();
                foreach (char g in parsed){
                    if (g == ' ') { space = true; }
                    else if (space) { if (g == s) { count++; space = false; } }
                }
                if (count > maxcount) { maxcount = count; }
                rating.Add(count);
                count = 0;
            }
            for (int i = 0; i < rating.Count; i++)
            {
                if (rating[i] == maxcount)
                { result += listBox3.Items.OfType<string>().ToList()[i] + "\n"; }
            }
            MessageBox.Show(result);
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
