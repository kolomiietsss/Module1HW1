using System;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Artem";
            string lastname = "Kolomiiets";
            int age = 20; //можем и после этого подсчитать количество лет до новой жизни в параме, но ты сказал, что можно и так)
            Console.WriteLine($"Name: {name} {lastname}, NEW LIFE COUNT: {40 - age} years");
        }
    }
}
