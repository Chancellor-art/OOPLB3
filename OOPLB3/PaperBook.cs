using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace OOPLB3
{
    class PaperBook : Book
    {
        private string type = "Бумажна книга";

        public PaperBook() : base()
        {
            
        }

        public PaperBook(string name, string avtor, int date) : base(name, avtor, date)
        {
            
        }

        public override void Info()
        {
            MessageBox.Show($"Данні книгі:\nНазва: {name} \nАвтор: {avtor} \nРік видання: {date} " +
                $"\nСкільки років книзі: {Num__year()} \nДоп. Інформація: {Year()} \nТип книгі: {type}", "Інформація",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
