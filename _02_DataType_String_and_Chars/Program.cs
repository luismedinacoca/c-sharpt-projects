namespace _02_DataType_String_and_Chars;

internal class Program
{
    private static void Main(string[] args)
    {
        // Conversion String to Numbers:
        var textAge = "-23";
        Console.WriteLine("👉🏽 textAge: " + textAge);
        Console.WriteLine("textAge.GetType(): " + textAge.GetType());
        Console.WriteLine("🟢 Convert.ToInt32(textAge)");
        var age = Convert.ToInt32(textAge);
        Console.WriteLine("age: " + age);
        Console.WriteLine("age.GetType(): " + age.GetType());
        Console.WriteLine();

        // String to Long number:
        var textBigNumber = "-900000000000";
        Console.WriteLine("👉🏽 textBigNumber: " + textBigNumber);
        Console.WriteLine("textBigNumber.GetType(): " + textBigNumber.GetType());
        Console.WriteLine("🟢 Convert.ToInt64(textBigNumber)");
        var bigNumber = Convert.ToInt64(textBigNumber);
        Console.WriteLine("bigNumber: " + bigNumber);
        Console.WriteLine("bigNumber.GetType(): " + bigNumber.GetType());
        Console.WriteLine();

        // String to Double
        var textNegative = "-55,3";
        Console.WriteLine("👉🏽 textNegative: " + textNegative);
        Console.WriteLine("textNegative.GetType(): " + textNegative.GetType());
        Console.WriteLine("🟢 Convert.ToDouble(textNegative)");
        var negative = Convert.ToDouble(textNegative);
        Console.WriteLine("negative: " + negative); // it's showing -553 
        Console.WriteLine("negative.GetType(): " + negative.GetType());
        Console.WriteLine();

        // String to Single:
        var textPrecision = "5,000001";
        Console.WriteLine("👉🏽 textPrecision: " + textPrecision);
        Console.WriteLine("textPrecision.GetType(): " + textPrecision.GetType());
        Console.WriteLine("🟢 Convert.ToSingle(textPrecision)");
        var precision = Convert.ToSingle(textPrecision);
        Console.WriteLine("precision: " + precision); // it's showing -553 
        Console.WriteLine("precision.GetType(): " + precision.GetType());
        Console.WriteLine();

        // String to Single:
        var textMoney = "23,75";
        Console.WriteLine("textMoney: " + textMoney);
        Console.WriteLine("textMoney.GetType(): " + textMoney.GetType());
        Console.WriteLine("Convert.ToDecimal(textMoney)");
        var money = Convert.ToDecimal(textMoney);
        Console.WriteLine("money: " + money);
        Console.WriteLine("money.GetType(): " + money.GetType());
        Console.WriteLine();

        Console.WriteLine(5.3 + 5.6); // outcome: 10,9 with coma
        //Console.WriteLine(5,5 + 5,6);

        /*
         * future error need to be fixed:
         * string textNumber = "12j"
         * ⚠️ exception
         */
    }
}