using System;

public class Method
{
 public void Amount(int value, double[] arr)
    {
        double[] amount = new double[value];
        double[] avgAmount = new double[value];
        double averageAmount = 0;
        double[] dispersion = new double[value];
        double dispersionOfRndVariable = 0;
        double randomVariable = 0;
        for (int i = 0; i < value; i++)
        {
            amount[i] = -Math.Log(arr[i], 2);
            avgAmount[i] = amount[i] * arr[i];
            averageAmount = avgAmount.Sum();
            dispersion[i] = (Math.Pow((amount[i] - averageAmount), 2)) * arr[i];
            dispersionOfRndVariable = dispersion.Sum();
            randomVariable = Math.Sqrt(dispersionOfRndVariable);

        }
    }
}
