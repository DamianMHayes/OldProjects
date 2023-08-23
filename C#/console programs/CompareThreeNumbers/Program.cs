// See https://aka.ms/new-console-template for more information

using System;
using static System.Console;
class compareThreeNumbers {

    static void Main() {


        string numberString;
        int num1, num2, num3;

        Write("Enter an Integer ");
        numberString = ReadLine();
        num1 = Convert.ToInt32(numberString);
        Write("Enter an Integer ");
        numberString = ReadLine();
        num2 = Convert.ToInt32(numberString);
        Write("Enter an Integer ");
        numberString = ReadLine();
        num3 = Convert.ToInt32(numberString);

        if (num1 == num2) {
            if (num3 == 1){
                WriteLine("All three numbers are equal");
            }else{
                WriteLine("First two are equal");
            }
        }else{
            if(num1 == num3) {
                WriteLine("First and last are equal");
            }else{
                WriteLine("No two numbers are equal");
            }
        }

    }
}
