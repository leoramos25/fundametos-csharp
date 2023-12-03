namespace Arquivos;

public static class Arquivo
{
    private const string fileName = "Cadastro.txt";

    public static void Criar()
    {
        var writer = new StreamWriter(fileName, true);

        Console.WriteLine("Informe um nome: ");

        string? nome = Console.ReadLine();

        writer.WriteLine($"Id..: {Random.Shared.Next(1, 100)}");
        writer.WriteLine($"Nome: {nome}");
        writer.WriteLine("---------------------------------");
        writer.Close();
    }

    public static void Ler()
    {
        var reader = new StreamReader(fileName);

        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        } 
    }

    public static void Excluir()
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
    }
}