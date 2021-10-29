using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculator");
            Console.WriteLine("==================================");
            Console.WriteLine();

            double kg, BMI, m ; //datatype for kilograms, BMI and meter
            string gender;



            Console.Write("Enter weight in kg: ");
            kg = Convert.ToDouble(Console.ReadLine()); //taking kilogram as input from user

            Console.Write("Enter height in m: ");
            m = Convert.ToDouble(Console.ReadLine());//taking meter as input from user

            Console.Write("Enter your Gender (women / men):");
            gender = Convert.ToString(Console.ReadLine());//taking gender as input from user

            BMI = kg / (m * m);

            //BMI for Women

            if (gender == "women")
            {
                Console.WriteLine("Your BMI ="+ BMI);

                if (BMI < 17.5)
                { Console.WriteLine("Anorexia"); }

                if (BMI < 19.1)
                { Console.WriteLine("Underweight"); }

                if (BMI < 19.1 && BMI > 25.8)
                { Console.WriteLine("In Normal Range"); }

                if (BMI < 25.8 && BMI >27.3)
                { Console.WriteLine("Marginally Overweight"); }

                if (BMI < 27.3 && BMI > 32.3)
                { Console.WriteLine("Overweight"); }

                if (BMI > 32.3)
                { Console.WriteLine("Very overweight or obese"); }

                if (BMI <35 && BMI >40)
                { Console.WriteLine("Severely Obese"); }

                if (BMI < 40 && BMI > 45)
                { Console.WriteLine("Morbidly Obese"); }

                if (BMI < 50 && BMI > 60)
                { Console.WriteLine("Super Obese"); }

            }

            //For men
            else if (gender == "men")
            {

                Console.WriteLine("Your BMI =" + BMI);

                if (BMI < 20.7)
                { Console.WriteLine("Underweight"); }

                if (BMI < 20.7 && BMI > 26.4)
                { Console.WriteLine("In Normal Range"); }

                if (BMI < 26.4 && BMI > 27.8)
                { Console.WriteLine("Marginally Overweight"); }

                if (BMI < 27.8 && BMI > 31.1)
                { Console.WriteLine("Overweight"); }

                if (BMI > 31.1)
                { Console.WriteLine("Very overweight or obese"); }

            }
            else
            {
                Console.WriteLine("Gender Invalid");
            }      
            
            Console.ReadLine();
        }
    }
}
