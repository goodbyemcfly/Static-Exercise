namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature (in fahreheit) that you would like converted to celcius");
            var fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{fahrenheit}F is equal to {TempConverter.FahrenheitToCelcius(fahrenheit)}C");

            Console.WriteLine("Please enter a temperature (in celcius) that you would like converted to fahrenheit.");
            var celcius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{celcius}C is equal to {TempConverter.CelciusToFahrenheit(celcius)}F");  
        }
    }
}
