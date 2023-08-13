namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kgs");
            float weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter your height in meters");
            float height = Convert.ToSingle(Console.ReadLine());
            float bmi = (weight / (height * height));
            if(bmi < 16)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". Your BMI is lower than the scale.");
            }
            else if(bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". You have a body weight deficit.");
            }
            else if(bmi <= 24)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". You are normal weighted.");
            }
            else if(bmi <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". Your weight is above the norm.");
            }
            else if(bmi <= 35)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". You are obese first degree.");
            }
            else if(bmi <= 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". You are obese second degree.");
            }
            else if(bmi > 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your BMI is " + bmi.ToString("0.0") + ". You are obese third degree.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("An error occured. The program will now self-destruct.");
            }
            Console.ReadLine();
        }
    }
}