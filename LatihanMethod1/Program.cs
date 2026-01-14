int a = 10, b = 2, c = 0;

void tambah(int a, int b)
{

    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");

}

void kurang(int a, int b)
{

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");

}

void kali(int a, int b)
{

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");

}

void Bagi(int a, int b)
{

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");

}


tambah(8, 2);
tambah(8, 1);
kurang(5, 2);
kali(3, 10);
Bagi(8, 4);
