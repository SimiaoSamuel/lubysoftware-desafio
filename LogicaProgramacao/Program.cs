using System;

namespace logicaprogramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //questao1
            Console.WriteLine(fatorial(5));
            
            //questao2
            Console.WriteLine(CalcularPremio(100,"basic",3));
            Console.WriteLine(CalcularPremio(100,"basic",null));
            Console.WriteLine(CalcularPremio(100,"",null));
            
            //questao3
            Console.WriteLine(ContarNumerosPrimos(20));
            
            //questao4
            Console.WriteLine(CalcularVogais("aeiou"));
            
            //questao5
            Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.000.800,00", "30%"));
            
            //questao6
            Console.WriteLine(CalcularDiferencaData("10122020", "25122020"));
            
            //questao7
            int[] vetor = ObterElementosPares(new int[]{1,2,3,4,5});
            foreach(int i in vetor)
            {
                Console.WriteLine(i);
            }
            
            //questao8
            string[] nomes = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
            };
            nomes = BuscarPessoa(nomes, "Doe");
            foreach(string x in nomes)
                Console.WriteLine(x);

            
            //questao9
            int[,] questao9 = TransformarEmMatriz("1,2,3,4,5,6");
            foreach(int x in questao9)
            {
                Console.WriteLine(x);
            }

            
            //questao10
            int[] questao10 = ObterElementosFaltantes(new int[] { 1,2,3,4,5 },new int[] { 1,2,5 });
            foreach(int j in questao10)
                Console.WriteLine(j);
        }

        static int fatorial(int num)
        {
            int fatorial = 1;
            for(int i = 1;i <= num;i++)
                fatorial *= i;
            return fatorial;
        }

        static double CalcularPremio(int value, string fator, int? parametroQueSobrescreve)
        {
            if(parametroQueSobrescreve != null)
                return (double)parametroQueSobrescreve * value;
            double valorTotal = 0;
            switch(fator.ToLower())
            {
                case "basic":
                    valorTotal = value * 1;
                    break; 
                case "vip":
                    valorTotal = value * 1.2;
                    break;
                case "premium":
                    valorTotal = value * 1.5;
                    break;
                case "deluxe":
                    valorTotal = value * 1.8;
                    break;
                case "special":
                    valorTotal = value * 2;
                    break;
                default:
                    return 0;
            }
            return valorTotal;
        }

        static int ContarNumerosPrimos(int value)
        {
            int numerosPrimos = 0;
            for(int i = 2; i <= value; i++)
            {
                bool isPrimo = true;
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                }
                if(isPrimo)
                    numerosPrimos++;
            }
            return numerosPrimos;
        }

        static int CalcularVogais(string texto)
        {
            int numeroVogais = 0;
            char[] vogais = new char[]{'a','e','i','o','u'};
            foreach(var letra in vogais)
            {
                if(texto.Contains(letra))
                    numeroVogais++;
            }
            return numeroVogais;
        }

        static string CalcularValorComDescontoFormatado(string valor, string desconto )
        {
            double valorFormatado = 0;
            if(valor.ToUpper().Contains("R$"))
                valorFormatado = Convert.ToDouble(valor.ToUpper().Replace("R$","").Replace(".","").Replace(",","").Trim());
            double porcentagem = Convert.ToDouble(desconto.Replace("%","")) / 100;
            valorFormatado = valorFormatado  - valorFormatado * porcentagem;
            string resultado = "" + valorFormatado;
            string cents = resultado.Substring(resultado.Length - 2);
            cents = "," + cents;
            resultado = resultado.Remove(resultado.Length - 2);
            int tamanho = resultado.Length;
            string reais = "";
            string reaisTrue = "";
            char[] numberInverted = resultado.ToCharArray();
            char[] number = new char[tamanho];
            for(int i = 0; i < tamanho; i++)
            {
                number[i] = numberInverted[tamanho - (i + 1)];
            }
            for(int i = 0; i < tamanho; i++)
            {
                if(i % 3 == 0 && i != 0)
                    reais += "." + number[i];
                else
                    reais += number[i];
            }
            for(int i = 0; i < reais.Length; i++)
            {
                reaisTrue += reais.ToCharArray()[reais.Length - (i + 1)];
            }
            return "R$ " + reaisTrue + cents;
        }

        static int CalcularDiferencaData(string primeiraData, string segundaData)
        {
            primeiraData = primeiraData.Replace("/","");
            segundaData = segundaData.Replace("/","");
            int primeiraDataDias, primeiraDataMes, primeiraDataAno, segundaDataDias, segundaDataMes, segundaDataAno;
            try
            {
                primeiraDataDias = Convert.ToInt16(primeiraData.Substring(0,2));
                segundaDataDias = Convert.ToInt16(segundaData.Substring(0,2));

                primeiraDataMes = Convert.ToInt16(primeiraData.Substring(2,2));
                segundaDataMes = Convert.ToInt16(segundaData.Substring(2,2));

                primeiraDataAno = Convert.ToInt16(primeiraData.Substring(4,4));
                segundaDataAno = Convert.ToInt16(segundaData.Substring(4,4));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            DateTime dataUm = new DateTime(primeiraDataAno,primeiraDataMes,primeiraDataDias);
            DateTime dataDois = new DateTime(segundaDataAno,segundaDataMes,segundaDataDias);
            var dias = (dataDois - dataUm).Days;
            return Math.Abs(dias);
        }

        static int[] ObterElementosPares(int[] vetor)
        {
            int[] vetorPares = new int[vetor.Length];
            int iterator = 0;
            foreach(int valor in vetor)
            {
                if(valor % 2 == 0)
                {
                    vetorPares[iterator] = valor;
                    iterator++;
                }
            }
            int[] resultado = new int[iterator];
            iterator = 0;
            foreach(int valor in vetorPares)
            {
                resultado[iterator] = valor;
                iterator++;
                if(iterator == resultado.Length)
                    break;
            }
            return resultado;
        }

        static string[] BuscarPessoa(string[] vetor, string palavra)
        {
            int iterator = 0;
            
            foreach(string pessoa in vetor)
            {
                if(pessoa.Contains(palavra))
                    iterator++;
            }
            
            string[] pessoas = new string[iterator];
            iterator = 0;
            
            foreach(string pessoa in vetor)
            {
                if(pessoa.Contains(palavra))
                    pessoas[iterator] = pessoa;
                iterator++;
            }
            return pessoas;
        }

        static int[,] TransformarEmMatriz(string valores)
        {
            string[] valoresVetor = valores.Split(",");
            int qtdVetores = valoresVetor.Length / 2;
            int[,] vetor = new int[qtdVetores,2];
            int iterator = 0;
            int iteratorDois = 0;
            foreach(string i in valoresVetor)
            {
                if(iterator % 2 == 0 && iterator != 0)
                {
                    iterator = 0;
                    iteratorDois++;
                }
                vetor[iteratorDois,iterator] =  Convert.ToInt16(i);
                iterator++;
            }
            return vetor;
        }

        static int[] ObterElementosFaltantes(int[] vetorUm, int[] vetorDois)
        {
            int iterator = 0;
            int iteratorDois = 0;
            foreach(int i in vetorUm)
            {
                foreach(int x in vetorDois)
                {
                    if(i == x)
                    {
                        vetorUm[iterator] = 0;
                        vetorDois[iteratorDois] = 0;
                    }
                    iteratorDois++;
                }
                iterator++;
                iteratorDois = 0;
            }

            int qtd = 0;

            foreach(int i in vetorUm)
            {
                if(i != 0)
                {
                    qtd++;
                }
                foreach(int x in vetorDois)
                {
                    if(x != 0)
                    {
                        qtd++;
                    }
                }
            }

            int[] numerosFaltantes = new int[qtd];
            iterator = 0;
            foreach(int i in vetorUm)
            {
                foreach(int x in vetorDois)
                {
                    if(0 != x)
                    {
                        numerosFaltantes[iterator] = x;
                        iterator++;
                    }
                }
                if(i != 0)
                {
                    numerosFaltantes[iterator] = i;
                    iterator++;    
                }
            }
            return numerosFaltantes;
        }
    }
}
