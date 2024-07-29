namespace _09_More_about_classes_and_methods;

class Program
{
    static void Main(string[] args)
    {
        // 1. create the class Car
        // 2. Create an instance of Car
        Car myCar = new Car();
        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1996;
        myCar.Color = "Silver";
        Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Make, 
            myCar.Model, 
            myCar.Year, 
            myCar.Color);
        Console.WriteLine("myCar.DetermineMarketValue(): {0:C}", myCar.DetermineMarketValue());
        Console.WriteLine("");
        
        Car myOtherCar = myCar;
        Console.WriteLine("{0} {1} {2} {3}", 
            myOtherCar.Make, 
            myOtherCar.Model, 
            myOtherCar.Year, 
            myOtherCar.Color);
        Console.WriteLine("");

        myOtherCar.Model = "98";
        Console.WriteLine("myOtherCar.Model = \"98\"");
        Console.WriteLine("");
        Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Make, 
            myCar.Model, 
            myCar.Year, 
            myCar.Color);
        Console.WriteLine("");
        
        Console.WriteLine("myCar.DetermineMarketValue(): {0:C}", myCar.DetermineMarketValue());
        Console.WriteLine("");

        myOtherCar = null;
        Console.WriteLine("myOtherCar = null"); // delete the reference!
        Console.WriteLine("");
        Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Make, 
            myCar.Model, 
            myCar.Year, 
            myCar.Color);
        Console.WriteLine("");
    }
    
    class Car
    {
        public string Make { get; set; }  //prop + tab + tab
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 2010)
                carValue = 10000M;
            else
                carValue = 2500;
            return carValue;
        }
    }
}