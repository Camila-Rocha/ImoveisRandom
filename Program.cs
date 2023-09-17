using System.Text.RegularExpressions;
namespace ProjetoImoveis
{
    internal class Program
    {        static void Main(string[] args)
        {
            Regex regexInt = new Regex(@"\d+");
            Regex regexDecimal = new Regex(@"(\.\d+)");
            bool verificadorBool = true;

            Console.WriteLine("Olá! Seja bem vindo(a)!");
            Console.WriteLine("Vamos fazer uma busca de imóvel para você!\n O resultado vária se a resposta contiver números na qual a soma for PAR (Casa), IMPAR (Apartamento), ou qualquer caractere diferente (Terreno)");

            for (; ; )
            {
                Console.Write("\nPor gentileza, digite um número inteiro de 0 à 1000 ou qualquer caractere para receber uma resposta correspondente: ");

                string resposta = Console.ReadLine();

                if (regexInt.Match(resposta).Success)
                {
                    MatchCollection todosOsNumerosEncontrados = regexInt.Matches(resposta);

                    if (!regexDecimal.IsMatch(resposta) == verificadorBool)
                    {
                        int resultadoSoma = 0;

                        for (int i = 0; i < todosOsNumerosEncontrados.Count; i++)
                        {
                            resultadoSoma = resultadoSoma += int.Parse(todosOsNumerosEncontrados[i].Value);
                        }

                        if (resultadoSoma < 0 || resultadoSoma > 1000)
                        {
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("O número informado está fora dos limites permitido (se sua resposta conter mais de um número nós fazemos a soma destes!)");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                        }

                        else
                        {
                            if (resultadoSoma % 2 == 0)
                            {
                                Console.WriteLine("\n---------------------------------------------------");
                                Console.WriteLine(Imoveis.Casa());
                                Console.WriteLine("\n---------------------------------------------------");
                            }

                            if (resultadoSoma % 2 == 1)
                            {
                                Console.WriteLine("\n---------------------------------------------------");
                                Console.WriteLine(Imoveis.Apartamento());
                                Console.WriteLine("\n---------------------------------------------------");
                            }
                        }
                    }

                    else
                        if (regexDecimal.IsMatch(resposta) == verificadorBool)
                    {
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Você digitou um número que contém casas decimais! aceitamos somente números em formato inteiro! ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("\n---------------------------------------------------");
                    Console.WriteLine(Imoveis.Terreno());
                    Console.WriteLine("\n---------------------------------------------------");
                }
            }
        }
    }
}