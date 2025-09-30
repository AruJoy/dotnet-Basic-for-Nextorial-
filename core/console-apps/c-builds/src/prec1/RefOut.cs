public class RefOut
{
    public static void Increment(ref int x)
    {
        x++;
    }
    public static bool TryDivide(int a, int b, out double result)
    {
        if (b == 0)
        {
            result = 0;
            return false;
        }
        result = (double)a / b;
        return true;
    }
}