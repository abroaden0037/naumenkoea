using System;
using System.ComponentModel.DataAnnotations;

class Polynomial
{
    private int degree;
    private double[] coeffs;

    public Polynomial()
    {
        degree = 0;
        coeffs = new double[1] { 0.0 };
    }

    public Polynomial(double[] new_coeffs)
    {
        degree = new_coeffs.Length - 1;
        coeffs = (double[])new_coeffs.Clone();
    }

    public int Degree
    {
        get { return degree; }
    }

    public double[] Coeffs
    {
        get { return (double[])coeffs.Clone(); }
    }

    public override string ToString()
    {
        string res = "";
        for (int i = 0; i < this.coeffs.Length; i++)
        {
            if (i > 0 & i != this.coeffs.Length)
            {
                if (this.coeffs[i] > 0)
                {
                    res += "+ ";
                }
                else if (this.coeffs[i] < 0)
                {
                    res += "- ";
                }
            }
            if (this.coeffs[i] == 0)
            {
                continue;
            }
            if (i == 0)
            {
                res += this.coeffs[i] + " ";
            }
            else if (i == 1)
            {
                res += Math.Abs(this.coeffs[i]) + "x" + " ";
            }
            else
            {
                res += Math.Abs(this.coeffs[i]) + "x^" + i + " ";
            }

        }
        return res;
    }
    public static Polynomial operator +(Polynomial obj1, Polynomial obj2)
    {
        double[] c1 = obj1.Coeffs;
        double[] c2 = obj2.Coeffs;
        while (c1.Length != c2.Length)
        {
            if (c1.Length > c2.Length)
            {
                c2.Append(0);
            }
            else
            {
                c1.Append(0);
            }
        }
        double[] res = {};
        for (int i = 0; i < c1.Length; i++)
        {
            res.Append(c1[i] + c2[i]);
        }
        Polynomial obj3 = new Polynomial(res);
        return obj3;
    }
    public static Polynomial operator * (Polynomial obj1, double k)
    {
        double[] c1 = obj1.Coeffs;
        for (int i = 0; i < c1.Length; i++)
        {
            c1[i] = c1[i] * k;
        }
        Polynomial obj3 = new Polynomial(c1);
        return obj3;
    }
}

class Programm
{
    static void Main(string[] args)
    {
        double[] coeffs = { 1.0, 0.0, 2.0, -3.0 };
        Polynomial p = new Polynomial(coeffs); // 1 + 2x^2

        Console.WriteLine(p);

        double[] coeffs2 = { 4.0, -1.0, 2.0};
        Polynomial p2 = new Polynomial(coeffs2);
        Polynomial p3 = p + p2;
        Console.WriteLine(p3);


        Console.WriteLine(p2 * 0.5);
    }
}
