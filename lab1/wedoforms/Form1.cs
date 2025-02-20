using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace wedoforms
{
    public partial class Form1 : Form
    {
        private bool tap; // для комбо с кликом
        private bool taptap; // для комбо с двойным кликом
        private bool praise_forbidden; // для блокирования комбобокса
        private bool souls_forbidden; // для блокирования радиокнопок
        CheckBox cb1;
        CheckBox cb2;
        Thread NewOne; // помогает избежать странного бага при ресете
        public Form1() // конструктор
        {
            InitializeComponent();
            cb1 = new CheckBox();
            cb2 = new CheckBox();
            //cb1.Top = 100;
            //cb1.Left = 200;
            cb1.Location = Location = new System.Drawing.Point(380, 20);
            cb1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb1.Name = "cb1";
            cb1.Text = "lock";
            //cb2.Top = 200;
            //cb2.Left = 200;
            cb2.Location = Location = new System.Drawing.Point(240, 205);
            cb2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb2.Name = "cb2";
            cb2.Text = "lock";
            this.cb1.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.cb2.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.cb1.MouseLeave += new System.EventHandler(this.bye_mouse);
            this.cb2.MouseLeave += new System.EventHandler(this.bye_mouse);
            Controls.Add(cb1);
            Controls.Add(cb2);
            this.CenterToScreen();
            this.KeyPreview = true;
            this.ContextMenuStrip = contextMenuStrip1;
            this.tap = false;
            this.taptap = false;
            this.praise_forbidden = false;
            this.souls_forbidden = false;
        }
        public void setAll() // закрыть текущую форму, начать новую
        {
            this.Close();
            NewOne = new Thread(form_reset_bugless);
            NewOne.SetApartmentState(ApartmentState.STA);
            NewOne.Start();
        }
        private void form_reset_bugless(object frm) // то, что попадает в новый поток
        {
            Application.Run(new Form1());
        }

        // КОМБИНАЦИИ С ФОРМОЙ
        
        private void Form1_MouseClick(object sender, MouseEventArgs e) // клик
        { if (e.Button == MouseButtons.Left) { tap = true; } }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e) // двойной клик
        { if (e.Button == MouseButtons.Left) { taptap = true; } }
        private void Form1_KeyDown(object sender, KeyEventArgs e) // комбинации с альтом
        {
            if (tap && e.Alt && e.KeyCode == Keys.I)
            { setAll(); }
            else if (taptap && e.Alt && e.KeyCode == Keys.X)
            { this.Close(); }
        }

        // МЕНЮ ОКНА, ВСЁ С ЦИФРАМИ
        
        private void ToolStripMenuItemdI_Click(object sender, EventArgs e) // отправить число из текстбокса в листбокс. Форматировать.
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
        private void ToolStripMenuItemdII_Click(object sender, EventArgs e) // удалить выделенные
        { foreach (string s in listBox1.SelectedItems.OfType<string>().ToList()) { listBox1.Items.Remove(s); } }

        private void ToolStripMenuItemdIII_Click(object sender, EventArgs e) // перенести с чётными целыми частями
        {
            foreach (string parsed in listBox1.Items.OfType<string>().ToList())
            {
                if (Int32.Parse(parsed.Split('.')[0]) % 2 == 0)
                { listBox2.Items.Add(parsed); }
            }
        }
        private void toolStripMenuItemdIV_Click(object sender, EventArgs e) // перенести среднее геометрическое
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

        // КОМБО БОКС
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // меняет заголовок окна
        { if (!praise_forbidden) { this.Text = "praise the " + comboBox1.SelectedItem.ToString() + "!"; } }
        private void comboBox1_KeyDown_1(object sender, KeyEventArgs e) // добавляет элементы на энтер
        {
            if (!praise_forbidden)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string addition = comboBox1.Text.Trim();
                    if (!string.IsNullOrEmpty(addition) && !comboBox1.Items.Contains(addition))
                    { comboBox1.Items.Add(addition); comboBox1.SelectedIndex = -1; }
                }
            }
        }

        // РАДИОКНОПКИ, МЕНЯЮТ ЦВЕТ
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e) // с хард-коженной проверкой на чекбоксы
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#777799"); }
            else { radioButton1.Checked = false; }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#666688"); }
            else { radioButton2.Checked = false; }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#555577"); }
            else { radioButton3.Checked = false; }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#444466"); }
            else { radioButton4.Checked = false; }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#333355"); }
            else { radioButton5.Checked = false; }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!souls_forbidden) { this.BackColor = ColorTranslator.FromHtml("#222244"); }
            else { radioButton6.Checked = false; }
        }

        // ВВОД ЦИФР В ТЕКСТБОКС. ПОПРОБУЙТЕ СЛОМАЙТЕ ЭТО! (ой, Ctrl+V...)

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // оно работает.
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

        // ЧЕКБОКСЫ
        
        /*
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // блокирует комбобокс
        { praise_forbidden = checkBox1.Checked; }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) // блокирует радиокнопки
        { souls_forbidden = checkBox2.Checked; }
        */
        // КОНТЕКСТНОЕ МЕНЮ
        
        private void ToolStripMenuItemI_Click(object sender, EventArgs e) // отправить строку
        { if (!string.IsNullOrEmpty(textBox2.Text)) { listBox3.Items.Add(textBox2.Text); } }
        private void ToolStripMenuItemII_Click(object sender, EventArgs e) // удалить выделение
        { foreach (string s in listBox3.SelectedItems.OfType<string>().ToList()) { listBox3.Items.Remove(s); } }
        private void ToolStripMenuItemIII_Click(object sender, EventArgs e) // соединяет короткую с длинной
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
        private void ToolStripMenuItemIV_Click(object sender, EventArgs e) // ищет по букве
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

        // ВЫВОД СТАТУСОВ

        private void hi_mouse(object sender, EventArgs e)
        {
            dynamic meme = (dynamic)sender;
            toolStripStatusLabel1.Text = meme.Name.ToString();
            toolStripStatusLabel2.Text = meme.Text;
        }

        private void bye_mouse(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
            toolStripStatusLabel2.Text = string.Empty;
        }
    }
}
