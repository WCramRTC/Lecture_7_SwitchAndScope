using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7_SwitchAndScope
{
    internal class Program
    {
        // Global
        static string cat = "Mochi";
        static int countEven = 0;
        static int countOdd = 0;
        static int correct = 0;
        static void Main(string[] args)
        {

            MathReview();
           
            


        } // Main

        public static void MathLibrary()
        {

            //// r = c / (2 * π)
            //double c = 123353;
            //double r = c / (2 * Math.PI);
            //Console.WriteLine(r);

            double sqrt = Math.Sqrt(345983408954309854);

            Console.WriteLine(sqrt);

            // Parenthese, Multi, Div, Add, Subtraction

            //Console.WriteLine((int)yards);
        }

        public static void MathProblem()
        {
            int inches, yards, foot;
            const double inchesInYard = 36.0;
            const double inchesInFoot = 12.0;

            inches = 12345;

            yards = inches / (int)inchesInYard;
            inches %= (int)inchesInYard;

            foot = inches / (int)inchesInFoot;
            inches %= (int)inchesInFoot;

            Console.WriteLine($"{yards} yards, {foot} feet, {inches} inches");

            // Explict and Implicit
            // Explict - Say that we intend to cast
            // Implict - Automicatically cast
            int wholeYard = (int)yards;
            double inchesDec = inches;
        }

        public static void Menu()
        {
            // Switch
            // switch
            // case
            // break
            // default

            // 1 - Ask Multiplication question
            // 2 - Ask Division Question
            // 3 - Exit
            Console.WriteLine("1 - Multiplicatoin");
            Console.WriteLine("2 - Division");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("Enter a selection: ");
            string userInput = Console.ReadLine();

            // Switch Code block
            switch (userInput)
            {
                case "1":
                    Multiplication();
                    break;

                case "2":

                    break;
                case "3":

                    break;

                default:
                    Console.WriteLine("Enter a valid input.");
                    break;


            } // End of switch
        }

        public static void Multiplication()
        {
            Console.WriteLine("Multi 1");
            Console.WriteLine("Multi 2");
        }
        public static void DisplayEvenAndOdd()
        {
            Console.WriteLine($"Count Even: {countEven}");
            Console.WriteLine($"Count Odd: {countOdd}");

            if(countEven > 50)
            {
                Console.WriteLine("Thatas a lot of even numbers.");
            }
        }

        public static void TrueFalse()
        {
            int count = 0;
        trueFalse:;

            Console.WriteLine("Is true or false?");
            bool tf = bool.Parse(Console.ReadLine());

            try
            {
                if (tf == true)
                {

                    count += 1;
                }
                else
                {
                    count -= 1;
                }
                Console.WriteLine(count);
                goto trueFalse;
            }
            catch
            {
                goto breakMeOut;
            }

        breakMeOut:;

        }

        public static void ScopeExample()
        {
            Console.WriteLine(cat);

        } // ScopeExample

        public static void MathReview()
        {
        //An Italian restaurant receives a shipment of 86 veal cutlets. If it takes 3 cutlets to make a dish, how many cutlets will the restaurant have left over after making as many dishes as possible?

        howMany:; // Label
            try
            {
                Random rand = new Random();
                int totalVealCutlets = rand.Next(12, 121); // 12 - 120
                int cutletsPerDish = rand.Next(1, 5); // 1 - 4
                Console.WriteLine($"An Italian restaurant receives a shipment of {totalVealCutlets} veal cutlets. If it takes {cutletsPerDish} cutlets to make a dish, how many cutlets will the restaurant have left over after making as many dishes as possible?");

                //Console.WriteLine("How many Veal Cutlets: ");
                //int totalVealCutlets = int.Parse(Console.ReadLine());
                //Console.WriteLine("How many per dish: ");
                //int cutletsPerDish = int.Parse(Console.ReadLine());

                int howManyDish = totalVealCutlets / cutletsPerDish;
                int howManyCutletsLeftOver = totalVealCutlets % cutletsPerDish;

                Console.WriteLine("What is the answer?");
                int userAnswer = int.Parse(Console.ReadLine());

                if(userAnswer == howManyCutletsLeftOver)
                {
                    Console.WriteLine($"Total Veal Cutlets: {totalVealCutlets}");
                    Console.WriteLine($"How many per dish: {howManyDish}");
                    Console.WriteLine($"How many cutlets were left over: {howManyCutletsLeftOver}");
                    correct++;
                }
                else
                {
                    Console.WriteLine("That is the wrong answer");
                }
                Console.WriteLine($"You have gotten {correct} correct");
                goto howMany;

            }
            catch
            {
                Console.WriteLine("Enter valid numbers");
                goto howMany; // Goes to label how many 
            }

        } // Math Review

        // Math Library


    } // class

} // namespace
