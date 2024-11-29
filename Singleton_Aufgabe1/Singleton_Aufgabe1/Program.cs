
using Singleton_Aufgabe1;

StandardInterestRate obj1 = StandardInterestRate.GetInstance();

Console.WriteLine(obj1.interestRate);

obj1.interestRate = 5;

Console.WriteLine(obj1.interestRate);