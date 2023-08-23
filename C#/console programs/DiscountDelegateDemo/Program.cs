using System;
using static System.Console;
delegate void DiscountHandler(ref double saleAmount);

class DiscountDelegateDemo{
    public static void StandardDiscount(ref double saleAmount)
    {
        const double DISCOUNT_RATE = 0.05;
        const double CUTOFF = 1000.0;
        double discount;

        if(saleAmount >= CUTOFF)
        {
            discount = saleAmount*DISCOUNT_RATE;
        }
        else
        {
            discount = 0;
        }
        saleAmount -= discount;
    }

    public static void PreferredDiscount(ref double saleAmount)
    {
        const double SPECIAL_DISCOUNT = 0.10;
        double discount = saleAmount*SPECIAL_DISCOUNT;
        saleAmount -= discount;
    }

    static void Main()
    {
        double saleAmount;
        char code;
        DiscountHandler firstDel, secondDel, thirdDel;
        firstDel = new DiscountHandler(StandardDiscount);
        secondDel = new DiscountHandler(PreferredDiscount);
        thirdDel = firstDel;
        thirdDel += secondDel;

        Write("Enter amount of sale ");
        saleAmount = Convert.ToDouble(ReadLine());
        Write("Enter S for standard discount, or P for prefered discount,/nor X for eXtreme discount ");
        code = Convert.ToChar(ReadLine());
        if(code == 'S')
        {
            firstDel(ref saleAmount);
        }
        else if (code == 'P')
        {
            secondDel(ref saleAmount);
        }
        else
        {
            thirdDel(ref saleAmount);
        }
        WriteLine("New sale amount is {0}", saleAmount.ToString("C2"));
    }
}