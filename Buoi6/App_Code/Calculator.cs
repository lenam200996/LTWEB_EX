using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Calculator
{
    public double tong(double a, double b)
    {
        return a + b;
    }

    public double tru(double a, double b)
    {
        return a - b;
    }

    public double nhan(double a, double b)
    {
        return a * b;
    }

    public double chiaNguyen(double a, double b)
    {
        return (int)(a / b);
    }

    public double chiaDu(double a, double b)
    {
        return a % b;
    }

    public double luyThua(double a, double b)
    {
        double lt = 1;
        for (int i = 1; i < b + 1; i++)
        {
            lt *= a;
        }

        return lt;
    }
}
