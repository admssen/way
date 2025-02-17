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
        private bool lbm;
        private bool rbm;
        public Form1()
        {
            InitializeComponent();
            BaseSettings();
            lbm = false;
            rbm = false;
        }
        private void BaseSettings()
        {
            this.KeyPreview = true;
            this.BackColor = Color.SeaShell;
            this.ContextMenuStrip = contextMenuStrip1;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { lbm = true; } }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { rbm = true; } }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.I && lbm)
            {
                Form1 reset = new Form1();
                reset.Show();
                this.Dispose(false);
            }else if (e.Alt && e.KeyCode == Keys.X && rbm)
            {
                this.Dispose(false);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {this.Text = "praise the "+comboBox1.SelectedItem.ToString()+"!";}
        private void comboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string addition = comboBox1.Text.Trim();
                if (!string.IsNullOrEmpty(addition) && !comboBox1.Items.Contains(addition))
                {
                    comboBox1.Items.Add(addition);
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
