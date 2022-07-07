using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversorDeMoedas.Entities
{
    public class Teste
    {
        public void MenuOpcoes(int opcaoDe, int opcaoPara)
        {
            Conversoes conversoes = new Conversoes();

            if (opcaoDe == 1)
            {
                if (opcaoPara == 2)
                {
                    conversoes.RealParaDolar(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.RealParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.RealParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.RealParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

            }

            else if (opcaoDe == 2)
            {
                if (opcaoPara == 1)
                {
                    conversoes.DolarParaReal(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.DolarParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.DolarParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.DolarParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

            else if (opcaoDe == 3)
            {
                if (opcaoPara == 1)
                {
                    conversoes.EuroParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.EuroParaDolar(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.EuroParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.EuroParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else if (opcaoDe == 4)
            {
                if (opcaoPara == 1)
                {
                    conversoes.IeneParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.IeneParaDolar(valorDigitado);

                }

                else if (opcaoPara == 3)
                {
                    conversoes.IeneParaEuro(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.IeneParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else if (opcaoDe == 5)
            {
                if (opcaoPara == 1)
                {
                    conversoes.LibraParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.LibraParaDolar(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.LibraParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.LibraParaIene(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

        }
    }
}
