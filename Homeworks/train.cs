using System;

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
}

class Programm
{
    static void Main(string[] args)
    {
        double[] coeffs = { 1.0, 0.0, 2.0, -3.0 };
        Polynomial p = new Polynomial(coeffs); // 1 + 2x^2

        Console.WriteLine(p);
    }
}
