// See https://aka.ms/new-console-template for more information

using Homework3;
//1.uzdevums
Phone samsung = new Phone();

Console.WriteLine($"Enter phone mark, size, model");

string mark = Console.ReadLine();
string size = Console.ReadLine();
string model = Console.ReadLine();

samsung.Mark = mark;
samsung.Size = size;    
samsung.Model = model;

Console.WriteLine($"Your phone mark is {samsung.Mark}, your phone size is {samsung.Size}, your phone model is {samsung.Model}");
Console.WriteLine($"Calling to phone which mark is {samsung.Mark}, size is {samsung.Size}, model is {samsung.Model}");
Console.WriteLine($"SMS sent to phone which mark is {samsung.Mark}, size is {samsung.Size}, model is {samsung.Model}");


//2.uzdevums
Car opel = new Car();
Console.WriteLine($"Enter car brand, numberPlate, speed");

string brand = Console.ReadLine();
string numberPlate = Console.ReadLine();
string speedText = Console.ReadLine();
double speed = double.Parse(speedText);


opel.Brand = brand;
opel.NumberPlate = numberPlate;
opel.Speed = speed;

Console.WriteLine($"Your car brand is {opel.Brand}, your car number is {opel.NumberPlate}, your car speed is {opel.Speed}");

speed = 10;
Console.WriteLine($"Sākam braukšanu ar ātrumu {opel.Speed}");

speed += 10;
Console.WriteLine($"Palielinam ātrumu - " + speed);

speed -= 10;
Console.WriteLine($"Samazinām ātrumu - " + speed);


speed = 0;
Console.WriteLine($"Apstāšanās pie ātruma {opel.Speed}");

Console.WriteLine($"Automašīna {opel.Brand} ar numurzīmi {opel.NumberPlate} uztaurē ar skaņas signālu BEEP");

//3.uzdevums - šo neizdevās izcīnīt..
Product table = new Product();

double height = 8;
double width = 6;
double weight = 7;

table.Height = height;



//4.uzdevums
Person ilga = new Person();

Console.WriteLine("Ievadi savu vārdu ?");
string name = Console.ReadLine();

Console.WriteLine("Ievadi savu uzvārdu ?");
string surname = Console.ReadLine();


Console.WriteLine("Kāds ir Tavs dzimšanas datums dd.mm.yyyy?");
string birthDateText = Console.ReadLine();
ilga.BirthDate = DateTime.Parse(birthDateText);

Console.WriteLine("Kāds ir Tavs hobijs ?");
string hobby = Console.ReadLine();


ilga.Name = name;
ilga.Surname = surname;
ilga.Hobby = hobby;

ilga.GetAge();
var age = DateTime.Now.Year - ilga.BirthDate.Year;
if (ilga.BirthDate > DateTime.Today.AddYears(-age)) age--;
//Console.WriteLine("Age = " + age);
//Console.ReadLine();


string userGreeting = ($"Sveiki, mani sauc {name} {surname}, man ir {age} un mans hobijs ir {hobby}!");
Console.WriteLine(userGreeting);


