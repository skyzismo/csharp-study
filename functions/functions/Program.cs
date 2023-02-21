internal class Program
{
    private static void Main()
    {
        FnTypeA();
        FnTypeB("função do tipo B\n");
        Console.WriteLine($"Essa é uma função do tipo C, que retorna a soma de 2 e 4: {FnTypeC()}\n");
        Console.WriteLine($"Essa é uma função do tipo D, que retorna o produto entre 2 e 4: {FnTypeD(2, 4)}");
    }

    // Tipos de Funções

    private static void FnTypeA()
    {
        Console.WriteLine($"Essa é uma função do tipo A \n");
    }

    private static void FnTypeB(string nome)
    {
        Console.WriteLine($"Essa é uma {nome}");
    }

    private static int FnTypeC()
    {
        return 2+4;
    }

    private static int FnTypeD(int a, int b)
    {
        return a * b;
    }
}