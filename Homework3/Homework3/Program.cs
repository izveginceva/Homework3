// See https://aka.ms/new-console-template for more information

using Homework3;

Phone samsung = new Phone();

Console.WriteLine($"Enter phone mark, size, model");

string mark = Console.ReadLine();
string size = Console.ReadLine();
string model = Console.ReadLine();

samsung.Mark = mark;
samsung.Size = size;    
samsung.Model = model;

Console.WriteLine($"Your phone mark is {samsung.Mark}, your phone size is {samsung.Size}, your phone model is {samsung.Model}");

