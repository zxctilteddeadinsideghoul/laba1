using System;
using System.Collections.Generic;


class Program{

    public static readonly string[] numberSeparators = new string[] {" ", "+", "-", "/", "*"};
    public static readonly string[] operationSeparators = new string[] {" ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
    
    static List<string> Separate(string expression, string[] Separator){
        List<string> result = new List<string>();
        
        foreach(string elem in expression.Split(Separator, StringSplitOptions.RemoveEmptyEntries)){
            result.Add(elem);
        }
        
        return result;
    }


    static double LegacyCalculate(List<string> numbers, List<string> operations){
            List<double> rNumbers = numbers.ConvertAll(x => double.Parse(x));
            int counter = operations.Count;
            for (int i = 0; i < counter; i++){
                switch(operations[i]){
                    case ("*"):
                        rNumbers[i] = rNumbers[i] * rNumbers[i+1];
                        rNumbers.RemoveAt(i+1);
                        operations.Remove("*");
                        i--; counter--;
                        break;
                    case ("/"):
                        rNumbers[i] = rNumbers[i] / rNumbers[i+1];
                        rNumbers.RemoveAt(i+1);
                        operations.Remove("/");//detete completed operation
                        i--; counter--;
                        break;
                }

            }    
            counter = operations.Count;
            for (int i = 0; i < counter; i++){
                switch(operations[i]){
                    case ("+"):
                        rNumbers[i] = rNumbers[i] + rNumbers[i+1];
                        rNumbers.RemoveAt(i+1);
                        operations.Remove("+"); //detete completed operation
                        i--; counter--;
                        break;
                    case ("-"):
                        rNumbers[i] = rNumbers[i] - rNumbers[i+1];
                        rNumbers.RemoveAt(i+1);
                        operations.Remove("-"); //detete completed operation
                        i--; counter--;
                        break;
                }

            }   
            return double.Parse(string.Join(" ", rNumbers));
        }


        static double Calculate(List<string> numbers, List<string> operations)
        {
            List<double> rNumbers = numbers.ConvertAll(x => double.Parse(x));
            return 1,2;
        }


    static void Main()
    {
        string exp = Console.ReadLine();
        List<string> numbers = Separate(exp, numberSeparators);
        List<string> operations = Separate(exp, operationSeparators);
        
        Console.WriteLine(Calculate(numbers, operations));


        //Console.WriteLine(string.Join(" ", numbers));
        //Console.WriteLine(string.Join(" ", operations));
    }
}
