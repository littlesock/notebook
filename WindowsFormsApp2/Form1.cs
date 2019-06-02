using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult .OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 搜尋取代ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f;
            textBox1.SelectionStart = 0;
            if (textBox1.SelectionLength > 0)
            {
                f = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart + 1);
            }
            else
            {
                f = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart);
            }
            if (f < 0)
            {
                MessageBox.Show("找不到XD");
            }
            else
            {
                textBox1.SelectionStart = f;
                textBox1.SelectionLength = textBox2.TextLength;
                textBox1.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        int mdx, mdy;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Left = panel1.Left + (e.X - mdx);
                panel1.Top = panel1.Top + (e.Y - mdy);
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox4.Text);
            float b = float.Parse(textBox5.Text);
            float c = a + b;
            label2.Text = c.ToString();
        }

        private void 計算機ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox7.Text);
            float b = float.Parse(textBox6.Text);
            float c = a - b;
            label3.Text = c.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox11.Text);
            float b = float.Parse(textBox10.Text);
            float c = a * b;
            label7.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox9.Text);
            float b = float.Parse(textBox8.Text);
            float c = a / b;
            label5.Text = c.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel2.Left = panel2.Left + (e.X - mdx);
                panel2.Top = panel2.Top + (e.Y - mdy);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void 成績計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBox12.Text);
            double B = Convert.ToDouble(textBox13.Text);
            double C = Convert.ToDouble(textBox14.Text);
            double D = Convert.ToDouble(textBox16.Text);
            double E = Convert.ToDouble(textBox15.Text);
            double i = A + B + C + D + E;
            double j = (A + B + C + D + E) / 5;
            label15.Text = i.ToString();
            label16.Text = j.ToString();
            if (j < 90)
            {
                label18.Text = "B";
                if (j < 80)
                {
                    label18.Text = "C";
                    if (j < 70)
                    {
                        label18.Text = "D";
                        if (j < 60)
                        {
                            label18.Text = "當掉";
                        }
                    }
                }
            }
            else
            {
                label18.Text = "A";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel3.Left = panel3.Left + (e.X - mdx);
                panel3.Top = panel3.Top + (e.Y - mdy);
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 連加計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBox17.Text);
            double B = Convert.ToDouble(textBox18.Text);
            double C = Convert.ToDouble(textBox19.Text);
            double Ans = 0;
            for (double i = A; i <= B; i += C)
            {
                Ans += i;
            }
            label24.Text = Ans.ToString();
        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBox17.Text);
            double B = Convert.ToDouble(textBox18.Text);
            double C = Convert.ToDouble(textBox19.Text);
            double Ans = 0;
            for (double i = A; i <= B; i += C)
            {
                Ans += i;
            }
            label24.Text = Ans.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel4.Left = panel4.Left + (e.X - mdx);
                panel4.Top = panel4.Top + (e.Y - mdy);
            }
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void 關於我ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string str = "這是一款新式的記事本，除了一般的使用工具外，它還多加了3種運算功能，目的是為了要讓使用者能一次享用到多種功能。";
            MessageBox.Show(str);
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }
    }
}
