namespace Funcoes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu primeiro nome: ");
        var primeiro = Console.ReadLine();
        Console.Write("Digite seu segundo nome: ");
        var segundo = Console.ReadLine();

        Console.WriteLine(NomeCompleto(primeiro, segundo));

        static string? NomeCompleto(string? firstName, string? lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
