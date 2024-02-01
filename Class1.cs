using System;

class Triangle
{
    private double side1;
    private double side2;

    public Triangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public string GetInfo()
    {
        return $"Side 1: {side1}\nSide 2: {side2}\nHypotenuse: {CalculateHypotenuse():F2}";
    }

    private double CalculateHypotenuse()
    {
        return Math.Sqrt(side1 * side1 + side2 * side2);
    }
}