namespace Tyuiu.KhvorykhVA.Sprint0.Task7.V0.Lib;

public class DataService
{
    public static int[] AdditonArrays(int[] num0ne, int[] numTwo)
    {
        int[] resultArray = new int[5];
        for (var i = 0; i < num0ne.Length; i++)
        {
            resultArray[i] = num0ne[i] + numTwo[i];

        }
        return resultArray;
    }
}