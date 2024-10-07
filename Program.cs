CalculoDoJuros();
static void CalculoDoJuros()
{
    Console.Clear();

    Console.Write("Informe o valor do capital inicial: ");
    double capital = double.Parse(Console.ReadLine());

    Console.Write("Informe a taxa de juros: ");
    double taxaJuros = double.Parse(Console.ReadLine());

    Console.Write("Informe o tempo da aplicação em meses: ");
    double tempoMeses = double.Parse(Console.ReadLine());

    double montanteFinal = ((taxaJuros / 1000) * capital * tempoMeses) + capital;

    Console.WriteLine(montanteFinal);
}