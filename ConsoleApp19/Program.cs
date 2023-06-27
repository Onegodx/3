// See https://aka.ms/new-console-template for more information
using ConsoleApp18;
using System;
using System.Numerics;
using Complex = ConsoleApp18.Complex;
//Миньков Владимир 22исп21 75 задание интерфейсы

Complex complex1 = new Complex(9, 3);
Complex complex2 = new Complex(4, -4);
Complex complex3 = (Complex)complex1.Add(complex2);
Console.WriteLine(complex3.ToString());
Complex complex4 = (Complex)complex1.Sub(complex2);
Console.WriteLine(complex4.ToString());
Complex complex5 = (Complex)complex1.Mult(complex2);
Console.WriteLine(complex5.ToString());
Complex complex6 = (Complex)complex1.Div(complex2);
Console.WriteLine(complex6.ToString());
Console.WriteLine(complex1.Equ(complex2));
Complex complex7 = (Complex)complex1.Conj();
Console.WriteLine(complex7.ToString());



Money money1 = new Money(100, 50); 
Money money2 = new Money(25, 250); 
Money result1 = (Money)money1.Add(money2); 
Money result2 = (Money)money1.Subtract(money2); 
Money result3 = (Money)money1.Multiply(1.5);
Money result4 = (Money)money1.Divide(2); 

Console.WriteLine(result1.ToString());
Console.WriteLine(result2.ToString());
Console.WriteLine(result3.ToString());
Console.WriteLine(result4.ToString());
