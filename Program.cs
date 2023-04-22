// Faça um programa que estime o custo de consumo de energia de um aparelho elétrico dado o seu consumo em kWh/mês e o uso diário (em horas).

Console.WriteLine("--- Custo de Energia ---\n");

Console.Write("Qual é o consumo mensal do aparelho em KWh? ");
double CustoEnergia = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantas horas p/dia o aparelho é usado? ");
double horasDiarias = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual é o custo do KWh em reais? ");
double custoKwh = Convert.ToDouble(Console.ReadLine());

double custoMensal = horasDiarias * CustoEnergia * custoKwh;

Console.WriteLine($"\nO custo de um mês de uso é: R$ {custoMensal}");

