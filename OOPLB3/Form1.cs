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
            Book book__standart = new Book("Атака титанів", "Хадзимэ Исаяма", 2021);
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
    }
}
