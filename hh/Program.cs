using System;
using ff;

namespace gg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Person
            Person person = new Person
            {
                Name = "Иван",
                Address = "Москва"
            };

            // Добавление объектов Hobby
            person.Hobbies.Add(new Hobby { Name = "Чтение", Description = "Чтение книг различных жанров" });
            person.Hobbies.Add(new Hobby { Name = "Фотография", Description = "Съемка и редактирование фотографий" });
            person.Hobbies.Add(new Hobby { Name = "Спорт", Description = "Регулярные занятия фитнесом" });

            // Показать информацию о человеке и его хобби
            person.ShowAll();

            Console.ReadLine();
        }
    }
}
