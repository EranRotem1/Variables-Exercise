﻿namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Eran";
            int age = 22;
            char last_in = "R";
            bool opinion = true;
            double year = 2000;
            float chicago = 1.33;
            decimal idk = 12.3;
            Console.WriteLine($"{name} {last_in} is {age}, which ofcouse means that he was born in the year {year}. " +
            $"He has been living in Chicago for {chicago} years. Why such a specific amount of time you ask? {opinion} " +
            $"but moving on, oh look at the time! I dont even have time to explain to you why {idk} is so important, welp, goodluck.");
        }
    }
}
