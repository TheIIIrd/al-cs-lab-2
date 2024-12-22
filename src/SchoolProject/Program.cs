/*
Задание 1
Создайте класс, представляющий учебный класс ClassRoom.

Создайте класс ученик - Pupil. 
В теле класса создайте методы void Study(), void Read(), void Write(),
void Relax().

Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от
класса базового класса Pupil и переопределите каждый из методов, в
зависимости от успеваемости ученика (реализация может быть произвольной,
например простой вывод на консоль разных строк).

Конструктор класса ClassRoom принимает аргументы типа Pupil, класс
должен состоять из 4 учеников. Предусмотрите возможность того, что
пользователь может передать 2 или 3 аргумента.

Выведите информацию о том, как все ученики экземпляра класса ClassRoom
умеют учиться, читать, писать, отдыхать. 

Примечание: при реализации возможности создания экземпляра класса
ClassRoom с произвольным количеством учеников воспользуйтесь ключевым
словом params.
*/

using System;

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает.");
    }
}

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится усердно.");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает много книг.");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет без ошибок.");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает после учебы устал.");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист учится и делает успехи.");
    }

    public override void Read()
    {
        Console.WriteLine("Хорошист читает достаточно.");
    }

    public override void Write()
    {
        Console.WriteLine("Хорошист пишет неплохо.");
    }

    public override void Relax()
    {
        Console.WriteLine("Хорошист тоже отдыхает.");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Ученик плохо учится.");
    }

    public override void Read()
    {
        Console.WriteLine("Ученик читает редко.");
    }

    public override void Write()
    {
        Console.WriteLine("Ученик пишет с ошибками.");
    }

    public override void Relax()
    {
        Console.WriteLine("Ученик предпочитает отдыхать больше, чем учиться.");
    }
}

public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 4)
        {
            throw new ArgumentException("Количество учеников должно быть от 2 до 4.");
        }
        this.pupils = pupils;
    }

    public void DisplayPupilsSkills()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcellentPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.DisplayPupilsSkills();
    }
}
