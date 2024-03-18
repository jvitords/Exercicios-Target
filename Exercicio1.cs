class Exerc1
{
    public int Indice { get; set; }
    public int Soma { get; set; }
    public int K { get; set; }

    public void ResolucaoExercicio1(int indice, int soma, int k)
    {
        while (k < indice)
        {
            k += 1;
            soma += k;
        }
        Console.WriteLine($"A soma é: {soma}");
    }
}