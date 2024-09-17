/*
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(),
SaveDocument().

В тело каждого из методов добавьте вывод на экран соответствующих строк:
"Документ открыт", "Редактирование документа доступно в версии Pro",
"Сохранение документа доступно в версии Pro".

Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите
следующие строки: "Документ отредактирован", "Документ сохранен в старом формате,
сохранение в остальных форматах доступно в версии Expert".

Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо
выводить на экран "Документ сохранен в новом формате".

В теле метода Main() реализуйте возможность приема от пользователя номера
ключа доступа pro и exp.

Если пользователь не вводит ключ, он может пользоваться только бесплатной версией
(создается экземпляр базового класса), если пользователь ввел номера ключа доступа
pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный
к базовому – DocumentWorker.
*/

using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт.");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro.");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro.");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован.");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert.");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentWorker documentWorker;

        Console.WriteLine("Введите ключ доступа (pro или exp):");
        string key = Console.ReadLine();

        switch (key?.ToLower())
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }

        // Пример работы с документом
        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}
