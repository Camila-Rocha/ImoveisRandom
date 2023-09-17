using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImoveis
{
    internal class Endereco
    {
        public static string SelecaoEndereco()
        {
            Random estado = new Random();
            int numeroEstado = estado.Next(1, 4);

            if (numeroEstado == 1)
            {
                string[] SP = { "Pompeia - SP / CEP: 17580-000", "Pinheiros - SP / CEP: 39100-000", "Vila Mariana - SP / CEP: 04094-000" };

                Random bairroSP = new Random();
                int posicaoBairroSP = bairroSP.Next(SP.Length);
                string selecaoBairro = SP[posicaoBairroSP];
                return selecaoBairro;
            }

            if (numeroEstado == 2)
            {
                string[] RJ = { "Botafogo - RJ / CEP: 22231-000", "Copacabana - RJ / CEP: 22070-000", "Flamengo - RJ / CEP: 22221-000" };

                Random bairroRJ = new Random();
                int posicaoBairroRJ = bairroRJ.Next(RJ.Length);
                string selecaoBairroRJ = RJ[posicaoBairroRJ];
                return selecaoBairroRJ;
            }

            else
            {
                string[] mG = { "Juiz de Fora - MG / CEP: 36010-000", "Uberlândia - MG / CEP: 38400-060", "Belo Horizonte - MG / CEP:31630-900" };

                Random bairroMG = new Random();
                int posicaoBairroMG = bairroMG.Next(mG.Length);
                string selecaoBairroMG = mG[posicaoBairroMG];
                return selecaoBairroMG;
            }
        }
    }
}
