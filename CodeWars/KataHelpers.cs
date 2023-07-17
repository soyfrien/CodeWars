public static class KataHelpers
{

    public static long Factorial(long length)
    {
        long x = 1;
        for (long i = length; i > 0; i--)
            x *= i;

        return x;
    }
}