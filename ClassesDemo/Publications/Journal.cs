using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Journal
    {
        public string Title { get; set; } // Название журнала
        public string Subject { get; set; } // Тематика журнала
        public DateTime PublishDate { get; set; } // Дата издания
        public int Pages { get; set; } // Количество страниц
        public decimal Price { get; set; }

        //метод класса - для покупки журнала
        public void BuyJournal()
        {
            Console.WriteLine($"Журнал '{Title}' приобретен за {Price} рублей.");
        }

        //метод класса -  для просмотра содержания журнала
        public void ViewContent()
        {
            Console.WriteLine($"Журнал '{Title}' содержит {Pages} страниц и посвящен теме: {Subject}.");
        }
    }
}
