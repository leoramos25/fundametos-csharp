namespace EstruturaControle;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número de 0 até 6: ");
        int diaSemana = int.Parse(Console.ReadLine());

        if (diaSemana == 0)
        {
            Console.WriteLine("Hoje é domingo");
        }

        switch (diaSemana)
        {
            case 0:
                Console.WriteLine("Domingo");
                break;
            case 1:
                Console.WriteLine("Segunda");
                break;
            case 2:
                Console.WriteLine("Terça");
                break;
            case 3:
                Console.WriteLine("Quarta");
                break;
            case 4:
                Console.WriteLine("Quinta");
                break;
            case 5:
                Console.WriteLine("Sexta");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Dia inválido");
                break;
        }

        var list = new List<String>() { "Leonardo", "Ramos", "Sousa" };

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        var i = 0;

        while (i > -10)
        {
            Console.WriteLine(i);
            i--;
        }

        var j = 0;

        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 2);
    }
}
