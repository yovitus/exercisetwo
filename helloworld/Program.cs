// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace helloworld;

public class Program {

    public static void Main(string[] args) {
        
        try {
        Console.WriteLine("Enter year: ");
        int input = Convert.ToInt32(Console.ReadLine());
        lessThan(input);
        bool answer = isYearLeapYear(input);
        if(!answer) Console.WriteLine("Nay");
        if(answer) Console.WriteLine("Yay");
        } catch (System.FormatException) {
            Console.WriteLine("Not an integer");
        }
    }

    public static void lessThan(int year) {
        if(year <= 1587) {
            throw new lessThanException("Leap year must be after the year 1587");
        }
    }

    public static bool isYearLeapYear(int year) {
        var output = false;
    
        if(year % 4 == 0) {
            if(year % 100 == 0) {
                if(year % 400 == 0) {
                    output = true;
                }
                else {
                    output = false;
                }
            }
            else {
                output = true;
            }
        } else {
            output = false;
        }
        return output;
    
    }

    public class lessThanException: Exception {

        public lessThanException(string message): base (message)
        {
            //message = "Leap year must be after the year 1587";
        }

    }
}