# Függvények C#-ban

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

Console.WriteLine(absMax(-5, 3));
```
Visszatérési értéke: 

```bash
5
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

Console.WriteLine(fibo(10));
```
Visszatérési értéke: 

```bash
55
```

## Jelszó erősség ellenőrző
A függvény egy szöveget vár paraméterül és egészszámmal tér vissza, így adja meg, hogy milyen erősségű a jelszó.

Lásd az alábbi példán:

```cs
int jelszo_erosseg(string jelszo)
{
    int erosseg = 1;
    if (jelszo.Length >= 5)
    {
        erosseg++;
    }
    if (jelszo.Length >= 8)
    {
        erosseg += 2;
    }

    foreach (char c in jelszo)
    {
        if (c == '_' || c == '-')
        {
            erosseg += 2;
        }
    }

    if (jelszo.Contains("jelszo") || jelszo.Contains("123"))
    {
        erosseg = 0;
    }

    if (jelszo.Length == 0)
    {
        erosseg = 0;
    }

    return erosseg;
}

Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));
```
Visszatérési értéke: 

```bash
10
```

## Magánhangzó törlés
A függvény egy szöveget vár paraméterül és szöveget is ad vissza. A bekért szövegből eltávolítja a magánhangzókat és a módosított szöveggel tér vissza.

Lásd az alábbi példán:

```cs
string maganhangzot_torol(string text)
{
    string maganhangzok = "aeiouöüóőúéáűí";
    string eredmeny = "";
    foreach (char c in text)
    {
        if (!maganhangzok.Contains(c))
        {
            eredmeny += c;
        }
    }
    return eredmeny;
}

Console.WriteLine(maganhangzot_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol.")); 
```
Visszatérési értéke: 

```bash
Idn Jv szgtn vltnk nyrln. Nm s tdtm, hgy lnvztk gy hlyt gy prgrmzs nylvrl.
```

## Elmozdulás
Ez a függvény szöveget vár paraméterül utasításként és szöveggel is tér vissza. A következő utasításokat várja szóköznélkül: J (jobrra), B (balra), F (fel), L (le). Majd szöveggel is tér vissza

Lásd az alábbi példán:
```cs
string elmozdulas(string iranyiats)
{
    int bal = 0;
    int fel = 0;

    string bElmoz = "";
    string fElmoz = "";

    foreach (char c in iranyiats)
    {
        if (c == 'j' || c == 'J')
        {
            bal--;
        }
        if (c == 'b' || c == 'B')
        {
            bal++;
        }
        if (c == 'l' || c == 'L')
        {
            fel--;
        }
        if (c == 'f' || c == 'F')
        {
            fel++;
        }
    }

    if (bal == 0 || fel == 0)
    {
        return "Nem mentünk sehova";
    }

    if (bal < 0)
    {
        bElmoz = "balra " + Math.Abs(bal) + " egységet";
    }
    else
    {
        bElmoz = "jobbra " + bal + " egységet";
    }

    if (fel < 0)
    {
        fElmoz = "lefelé " + Math.Abs(fel) + " egységet";
    }
    else
    {
        fElmoz = "felfelé " + fel + " egységet";
    }

    return bElmoz + " " + fElmoz;
}

Console.WriteLine(elmozdulas("JJFBFFFFFFBBBL")); 
```
Visszatérési értéke: 

```bash
jobbra 2 egységet felfelé 6 egységet
```