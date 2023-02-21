internal class Program
{
    /*
    private static void Main()
    {
        Console.WriteLine("Digite seu nome e, em seguida, os números que deseja somar:\n");

        string nome = Console.ReadLine()
            .Trim();

        int a = int.Parse(s: Console.ReadLine());

        int b = int.Parse(s: Console.ReadLine());

        Console.WriteLine($"\nOi, {nome}! A soma dos valores é {a + b}");
    }
    */

    private static int Main()
    {
        // ponto flutuante

        float f = 2.1f;
        double d = 4.6d;
        decimal m = 10.8m;

        // atribuição implícita e constantes JAVASCRIPTU UHUUU

        var idade = 20;

        f = idade; // conversão implícita

        const string cidade = "Manaus";

        // conversão explícita
        Console.WriteLine($"{(f*d*(float)m)}", idade, cidade);

        bool tipo = f == d;

        Console.WriteLine(tipo);

        // Strings

        string frase = " Meu nome é Luc@s Skyzismo ";

        Console.WriteLine(frase.Trim().Replace("Lucas", "Sky").Substring(0, 14));

        string cpf = "2345678900";

        Console.WriteLine(cpf.PadLeft(11,'1'));

        return idade;
    }
}