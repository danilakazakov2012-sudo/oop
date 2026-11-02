/*Person danya = new Person();

string personName = danya.name;
string personLastName = danya.last_name;
int personAge = danya.age;
Console.WriteLine($"Ваше имя: {personName},\n Ваша фамилия: {personLastName},\n Ваш возраст: {personAge}");

danya.methoD();
class Person
{
    public string name = "Undefined";
    public string last_name = "Kazakov";
    public int age;
    public double temperature;
    public void methoD()
    {
        Console.WriteLine($"Ваше имя: {name}\nВаша фамилия: {last_name}\nВаш возраст: {age}");
    }
}*/


public class Student
{
    public string firstName;
    public string lastName;
    public int age;
    public double temeperature;
    public string City;

    public void MethoD()
    {
        Console.WriteLine($"Всем Здравствуйте, меня зовут: {firstName}.\n Моя фамилия: {lastName}.\n также мне: {age} лет." +
            $"\nМоя температура: {temeperature},\n Также я живу в:{City}");
    }
}
//Основная программа!
public class Program
{
    public static void Main(string[] args)
    {
        //1.Создаем первый объект
        Student student1 = new Student();
        //2.Заполняем его поля данными
        student1.firstName = "Губка";
        student1.lastName = "боб";
        student1.age = 123;

        //3.Создаем второй объект!
        Student student2 = new Student();
        //4.Заполняем поля для второго объекта!
        student2.firstName = "Патрик";
        student2.lastName = "Звезда";
        student2.age = 20000;

        Console.WriteLine("Представляется первый житель бикини-ботомм");
        student1.MethoD();
        Console.WriteLine("Представляется второй житель бикини-ботомм");
        student1.MethoD();
    }
}

//ООП - это парадигма программирования, в которой
// прогрмма представляется как совокупность взаимодейсвующих объектов.
//Каждый объект является экземпляром определенного класса и инкаплусирует в себе
//как данные (поля), так и процедуры для их обработки (методы)

//ООП состоит из 3 китах!!!
//Инкапсуляция: Объединение данных и методов для их 
//обработоки в одном компоненте (объекте) и сокрытие
//деталей реализации от внешнего мира. Объект - это
//черный ящик, который предоставляет наружу только удобный интерфейс!

//Наследование: Механизм, который позволяет создавать 
//новый класс на основе существующего, перенимая его
//свойста и поведение и добавляя свои. (Например, классы)
//"Грузовик" и "Легковой автомобиль" могут наследовать
//общие свойсва от класса "автомобиля"!!!

//Полиморфизм: Способность объектов с одинаковым
//интерефейсом (например, с методом Move()) иметь
//различную реализацию этого интерфейса. (Например,
//Move() для объекта "Рыба" будет означать "плыть",
//а для объекта "птица" - "летать"

//Класс - это пользовательский тип данных, который служит
//шаблоном или чертежом для создавания объектов. Класс определяет,
//какие данные (поля) и какое поведение (методы)
//будут у всех объектов, созданных на его основе!
//По сути, объявляя класс, мы создаем новый тип данных в нашей 
//программе, на равне со встроенным int, string, & double.
