using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book__standart;
            PaperBook paperbook = new PaperBook("Антошка", "Невідомий", 1967);
            EBook ebook = new EBook("Антошка", "Невідомий", 1967);
            book__standart = paperbook;
            book__standart.Info();
            book__standart = ebook;
            book__standart.Info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Поточна кількість об'єктів: {Book.count}", "Увага!",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaperBook paperbook = new PaperBook();
            paperbook.Info();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaperBook paperbook = new PaperBook("Антошка", "Невідомий", 1967);
            paperbook.Info();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook("Антошка", "Невідомий", 1967);
            ebook.Info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook();
            ebook.Info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Random rnd = new Random();
            button.Width = 90;
            button.Height = 30;
            button.Left = rnd.Next(200);
            button.Top = rnd.Next(200);
            button.Text = ((Button)sender).Text;
            button.Parent = this;
            button.Show();
            button.Click += new System.EventHandler(this.button1_Click);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
                elem.Left += 50;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
                elem.Top += 50;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Book book__standart;
            book__standart = new PaperBook();
            book__standart.Info();
            book__standart = new EBook();
            book__standart.Info();
        }
    }
}
