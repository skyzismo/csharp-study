internal class Program
{
    private static void Main()
    {
        FnTypeA();
        FnTypeB("função do tipo B\n");
        Console.WriteLine($"Essa é uma função do tipo C, que retorna a soma de 2 e 4: {FnTypeC()}\n");
        Console.WriteLine($"Essa é uma função do tipo D, que retorna o produto entre 2 e 4: {FnTypeD(2, 4)}");
        Menu();
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

    private static void Menu()
    {
        Console.WriteLine("Escolha uma opção: a - Contar de 1 a 4, b - Contar de 6 a 9 ou c - Contar toda a lista\n");

        string option = Console.ReadLine();

        int[] array_1 = new int[] {1,2,3,4,5,6,7,8,9};

        switch (option)
        {
            case "a":

                for (int i = 0; i < array_1.Length - 4; i++)
                {
                    Console.WriteLine(array_1[i]);
                }break;
                
            case "b":

                for (int i = 5; i < array_1.Length; i++)
                {
                    Console.WriteLine(array_1[i]);
                }break;

            case "c":

                foreach (int num in array_1)
                {
                    Console.WriteLine(num);
                }break;

            default:
                Console.WriteLine("Opção inválida, tente novamente :)");
                break;
        }
    }
}