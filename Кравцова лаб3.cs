using System;
using System.Collections.Generic;

namespace DTPExample
{
    // Базовый класс для автомобиля
    public class Car
    {
        public string LicensePlate { get; set; }
    }

    // Класс для ДТП
    public class Accident<T> where T : Car
    {
        public List<T> Participants { get; set; }

        public Accident(List<T> participants)
        {
            if (!participants.Exists(x => string.IsNullOrEmpty(x.LicensePlate)) && participants is not null)
            {
                Participants = participants;
            }
            else
            {
                throw new ArgumentException(null, nameof(participants));
            }
        }



        public void PrintParticipants()
        {
            Console.Write("Список участников ДТП: ");
            foreach (var participant in Participants)
            {
                Console.Write(participant.LicensePlate + ", ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров автомобилей
            Car car1 = new Car { LicensePlate = "A123BC" };
            Car car2 = new Car { LicensePlate = "B456DE" };
            Car car3 = new Car { LicensePlate = "C789FG" };

            // Создание экземпляра ДТП с автомобилями в качестве участников
            Accident<Car> accident = new Accident<Car>(new List<Car> { car1, car2, car3});

            // Вывод списка участников ДТП
            accident.PrintParticipants();
        }
    }
}
