using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte ByteExample = 1;
            //int IntExample = 2;
            float FloatExample = 3.3F;
            //double DoubleExample = -4.4;

    
            double BinaryErrorExample = (double)FloatExample;
            int BadCastExample = (int) FloatExample;

            //System.Console.WriteLine($"byteExample = {ByteExample}.");
            //System.Console.WriteLine($"intExample = {IntExample}.");
            System.Console.WriteLine($"floatExample = {FloatExample}.");
            //System.Console.WriteLine($"doubleExample = {DoubleExample}");
            System.Console.WriteLine($"binaryErrorExample = {BinaryErrorExample}.");
            //System.Console.WriteLine($"badCastExample = {BadCastExample}.");
            
            
            
            
            
            
            
            System.Console.WriteLine($"Rounding after casting ="+ 
                $" {Math.Round(BinaryErrorExample, 2)}");


        }
    }
}
