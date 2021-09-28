using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace OOPLB3
{
    abstract class Book
    {
        public static int count = 0;
        private int nomer;

        protected string name;
        protected string avtor;
        protected int date;

        public Book()
        {
            this.name = Interaction.InputBox("Введіть назву книгі", "Введення");
            this.avtor = Interaction.InputBox("Введіть автора книгі", "Введення");
            this.date = Convert.ToInt32(Interaction.InputBox("Введіть рік книгі", "Введення"));

            count++;
            nomer = count;
        }

        ~Book()
        {
            MessageBox.Show($"Знишується книга №{nomer}", "Warning", MessageBoxButtons.OK);
            count--;
        }

        public Book(string name, string avtor, int date)
        {
            this.name = name;
            this.avtor = avtor;
            this.date = date;
        }

        protected virtual string Year()
        {
            if (date >= 2010) return " Нова книга";
            else return " Стара книга";
        }

        protected virtual string Num__year()
        {
            int num = 2021 - date;
            if (num == 0) return " Цього річна книга";
            else return Convert.ToString(num);
        }

        public virtual void Info()
        {
            MessageBox.Show($"Данні книгі:\nНазва: {name} \nАвтор: {avtor} \nРік видання: {date} " +
                $"\nСкільки років книзі: {Num__year()} \nДоп. Інформація: {Year()}", "Інформація", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
