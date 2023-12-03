using System.ComponentModel.Design;

namespace Linq;

public static class Linq
{
    public static void WhereTeste()
    {
        var nome = "Leonardo Ramos de Sousa";
        var resultado = nome.Where(p => p == 'a');
        var resultado2 = from c in nome where c == 'o' select c;

        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }

        foreach (var letra in resultado2)
        {
            Console.WriteLine(letra);
        }
    }

    public static void Ordenar()
    {
        var numeros = new int[] { 10, 9, 6, 45, 89, 41, 23, 403, 67, 12 };
        
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("===== LISTA ORDENADA ASC =====");

        var numerosAsc = numeros.OrderBy(x => x);

        foreach (var numero in numerosAsc)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("===== LISTA ORDENADA DESC =====");

        var numerosDesc = numeros.OrderByDescending(x => x);

        foreach (var numero in numerosDesc)
        {
            Console.WriteLine(numero);
        }
    }
}