﻿// This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name:"); //Output
//string-sõne
string userName;

userName = Console.ReadLine();//Input

Console.WriteLine("Hello" + "," + userName + "!"); //Output
// string interpolation 

Console.WriteLine($"Hello, {userName} !"); //Output
