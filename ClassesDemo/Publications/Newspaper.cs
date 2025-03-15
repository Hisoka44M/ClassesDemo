using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Newspaper
    {
        public string Title { get; set; } // Название газеты
        public string Headline { get; set; } // Заголовок главной полосы
        public DateTime PublishDate { get; set; } // Дата издания
        public int Pages { get; set; } // Количество страниц
        public decimal Price { get; set; }

        //метод класса для покупки газеты
        public void BuyNewspaper()
        {
            Console.WriteLine($"Газета '{Title}' приобретена за {Price} рублей.");
        }

        //метод класса - для просмотра заголовка
        public void ViewHeadline()
        {
            Console.WriteLine($"Газета '{Title}' Дата: {PublishDate.ToShortDateString()}) - Заголовок: {Headline}");
        }
    }
}
