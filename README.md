# Absolut Maximum és Fibonacci C#-ban

## absMax függvény

A függvény két egész számot vár paraméterül majd ezen számok abszolút értékének maximumát adják vissza

Lásd az alábbi példán:

```cs
int absMax (int a, int b)
{
    int absA = Math.Abs(a);
    int absB = Math.Abs(b);
    if (absA > absB)
        return absA;
    else
        return absB;
}

Console.WriteLine(absMax(-5, 3)); // visszatérési érték 5
```


## Fibonacci függyvény (fibo)

A függvény egy egész számot kér paraméterül majd ennek a fibonacci számsor értékét adja vissza.

Lásd az alábbi példán:
```cs
int fibo(int n)
{
    if (n <= 1)
        return n;
    else
        return fibo(n - 1) + fibo(n - 2);
}

Console.WriteLine(fibo(10)); // visszatérési érték 55
```