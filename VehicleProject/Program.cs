/*
Задание 2
Создайте класс vehicle.
В теле класса создайте поля: координаты и параметры средств
передвижения (цена, скорость, год выпуска).

Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.

Написать программу, которая выводит на экран информацию о каждом
средстве передвижения.

Примечание: избегайте дублирования кода, используйте ключевое слово
base после объявления конструкторов в классах наследниках для вызова
и передачи параметров в конструктор базового класса.
*/

using System;

class Vehicle
{
    // Поля базового класса
    public double X { get; set; } // Координаты
    public double Y { get; set; }
    public decimal Price { get; set; } // Цена
    public double Speed { get; set; } // Скорость
    public int YearOfManufacture { get; set; } // Год выпуска

    // Конструктор базового класса
    public Vehicle(double x, double y, decimal price, double speed, int year)
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        YearOfManufacture = year;
    }

    // Метод для отображения информации
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Координаты: ({X}, {Y})");
        Console.WriteLine($"Цена: {Price}");
        Console.WriteLine($"Скорость: {Speed}");
        Console.WriteLine($"Год выпуска: {YearOfManufacture}");
    }
}

// Производный класс Plane
class Plane : Vehicle
{
    public double Altitude { get; set; } // Высота
    public int NumberOfPassengers { get; set; } // Количество пассажиров

    public Plane(double x, double y, decimal price, double speed, int year, double altitude, int numberOfPassengers)
        : base(x, y, price, speed, year)
    {
        Altitude = altitude;
        NumberOfPassengers = numberOfPassengers;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Высота: {Altitude}");
        Console.WriteLine($"Количество пассажиров: {NumberOfPassengers}");
    }
}

// Производный класс Car
class Car : Vehicle
{
    public int NumberOfPassengers { get; set; } // Количество пассажиров

    public Car(double x, double y, decimal price, double speed, int year, int numberOfPassengers)
        : base(x, y, price, speed, year)
    {
        NumberOfPassengers = numberOfPassengers;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество пассажиров: {NumberOfPassengers}");
    }
}

// Производный класс Ship
class Ship : Vehicle
{
    public int NumberOfPassengers { get; set; } // Количество пассажиров
    public string PortOfRegistry { get; set; } // Порт приписки

    public Ship(double x, double y, decimal price, double speed, int year, int numberOfPassengers, string portOfRegistry)
        : base(x, y, price, speed, year)
    {
        NumberOfPassengers = numberOfPassengers;
        PortOfRegistry = portOfRegistry;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество пассажиров: {NumberOfPassengers}");
        Console.WriteLine($"Порт приписки: {PortOfRegistry}");
    }
}

// Основная программа
class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Plane(10, 20, 500000m, 900, 2020, 10000, 180),
            new Car(5, 10, 20000m, 120, 2018, 5),
            new Ship(15, 25, 800000m, 30, 2021, 100, "Нью-Йорк")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine(); // Разделяем вывод между средствами передвижения
        }
    }
}
