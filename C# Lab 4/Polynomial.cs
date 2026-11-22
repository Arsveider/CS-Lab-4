using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

internal class Polynomial
{
    private double a, b, c;

    public Polynomial(double a, double b, double c)
    {
        this.a = a; 
        this.b = b; 
        this.c = c;
    }

    public string Solve()
    {
        double D = b*b - 4*a*c;
        if (a != 0)
        {
            if (D < 0)
            {
                return "Решений нет.";
            }

            if (D > 0)
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return $"Решения уравнения: x1 = {x1} x2 = {x2}";
            }
            double x = -b / (2 * a);
            return $"Решение уравнения: x = {x}";
        }
        else
        {
            if (b != 0)
            {
                double x = (-c) / b;
                return $"Решение уравнения: x = {x}";
            }
            else
            {
                if (c == 0)
                    return "x может принимать любое значение";
                else
                    return "Нет решений";
            }
        }
    }
}
