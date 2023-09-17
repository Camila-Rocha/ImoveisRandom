using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImoveis
{
    internal class Imoveis
    {
        public static string Casa()
        {
            string[] tipoCasa = { "Condominio: Não", "Condominio: Sim" };

            Random tipo = new Random();

            int posicaoTipoCasa = tipo.Next(tipoCasa.Length);

            string aleatorioCasaFinal = tipoCasa[posicaoTipoCasa];

            int[] tamanho = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 };

            Random tamanhoCasa = new Random();

            int posicaoTamanhoCasa = tamanhoCasa.Next(tamanho.Length);

            int tamanhoCasaAleatorioFinal = tamanho[posicaoTamanhoCasa];

            return "\nOpção resultante foi CASA!\n\nLocalização: " + Endereco.SelecaoEndereco() + "\n\nTamanho: " + tamanhoCasaAleatorioFinal + "m2\n\n" + aleatorioCasaFinal;
        }

        public static string Apartamento()
        {
            String[] nomesApartamento = { "Edificio Nova Era", "Condominio Vallentin's", "Blue Times" };

            Random nomeAp = new Random();

            int nomeCondominio = nomeAp.Next(nomesApartamento.Length);

            String nomeCondominioFinal = nomesApartamento[nomeCondominio];

            int[] aluguel = { 700, 750, 800, 850, 900, 950, 1000, 1050, 1100, 1150, 1200, 1250, 1300, 1350, 1400, 1450, 1500 };

            Random aluguelAleatorio = new Random();

            int aluguelPosicao = aluguelAleatorio.Next(aluguel.Length);

            int aluguelAleatorioFinal = aluguel[aluguelPosicao];

            return "\nOpção resultante foi APARTAMENTO!\n\nLocalização: " + Endereco.SelecaoEndereco() + "\n\nEdificio: " + nomeCondominioFinal + "\n\nValor do aluguel: R$" + aluguelAleatorioFinal.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static string Terreno()
        {
            int[] terrenoTamanho = { 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            int[] terrenoValor = { 100000, 130000, 160000, 190000, 220000, 250000, 280000, 310000, 340000, 370000, 400000 };

            Random terrenoAleatorio = new Random();

            int terrenoPosicao = terrenoAleatorio.Next(terrenoTamanho.Length);

            int terrenoTamanhoFinal = terrenoTamanho[terrenoPosicao];

            return "\nOpção resultante foi TERRENO!!\n\nLocalização: " + Endereco.SelecaoEndereco() + "\n\nTamanho: " + terrenoTamanhoFinal + "\n\nValor do terreno: R$" + terrenoValor[terrenoPosicao].ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}