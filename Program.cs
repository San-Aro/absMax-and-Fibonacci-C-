int fibo(int n)
{
    if (n <= 1)
        return n;
    else
        return fibo(n - 1) + fibo(n - 2);
}

Console.WriteLine(fibo(10));


int absMax (int a, int b)
{
    int absA = Math.Abs(a);
    int absB = Math.Abs(b);
    if (absA > absB)
        return absA;
    else
        return absB;
}

Console.WriteLine(absMax(-5, 3));
