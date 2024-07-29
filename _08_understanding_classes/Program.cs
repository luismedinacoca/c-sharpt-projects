namespace _08_understanding_classes;

class Program
{
    static void Main(string[] args)
    {
        /*
         string car1Make;
         string car1Model;
         int car1Year;
         string car1Color;

         string car2Make;
         string car2Model;
         int car2Year;
        */
        
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
        decimal value = DetermineMarketValue(myCar);
        Console.WriteLine("value: {0:C}", value);
        Console.WriteLine("myCar.DetermineMarketValue(): {0:C}", myCar.DetermineMarketValue());

    }
    // 1. Creating a blueprint of Car
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
    
    private static decimal DetermineMarketValue(Car car)
    {
        decimal carValue = 1000.0M;
        /*
         * Someday I might look up the car online webservice
         * to get moe accurate value.
         */
        return carValue;
    }
}