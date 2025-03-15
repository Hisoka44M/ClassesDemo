﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
#pragma warning disable

    internal class Book
    {
        public string title; //поле класса - хранит название книги
        public string autor; //поле класса - хранит автора книги
        bool isReading = false; //поле класса - хранит статус книги (выдана ли она читателю)

        //метод класса - печатает в консоль информацию о книге
        public void GetInfo()
        {
            Console.WriteLine($"{autor} : {title}");
        }
        //метод класса - выдает книгу читателю и ставит отметку о выдаче
        public void GetBoot()
        {
            if (isReading)
                Console.WriteLine($"книга {title} в данный момент выдана другому читателю");
            else
            {
                isReading = true;
                Console.WriteLine("книга выдана на неделю");
            }
        }

        //метод класса - проверяет возвращена ли книга
        public void ReturnBook()
        {
            if (isReading)
            {
                isReading = false;
                Console.WriteLine("книга возвращена и теперь доступна для выдачи");
            }
            else
            {
                Console.WriteLine("книга уже находится в библиотеке");
            }
        }
    }
}
