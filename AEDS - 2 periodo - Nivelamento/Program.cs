using System;

namespace AEDS___2_periodo___Nivelamento
{
    class Program
    {

        /***********
        * Funções auxiliares
        * **********/
        static int get_best_week(float[] monthsWeeks)
        {
            float valHightestWeek = 0;
            int highestWeek = 0;

            for (int i = 0; i < 4; i++)
            {
                if (valHightestWeek < monthsWeeks[i])
                    highestWeek = i;
            }

            return (highestWeek + 1);
        }

        /***********
         * Questão 01
         * **********/
        static void questao_01()
        {

            float[,] vendas = new float[12, 4];
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            // Variaveis de resultado
            float totalMes = 0, totalAno = 0;
            float[] weekVal = { 0, 0, 0, 0 };

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("\n\nDigite o valor em vendas de {0} na {1}° semana", meses[i], (j + 1));
                    vendas[i, j] = float.Parse(Console.ReadLine());

                    // Acrescimo de faturamento anual
                    totalAno += vendas[i, j];

                    // Checagem de melhor semana
                    weekVal[j] += vendas[i, j];

                }
            }

            // Exibição do total mês
            Console.WriteLine("\nResultados por mês: ");
            for (int i = 0; i < 12; i++)
            {
                totalMes = 0;
                for (int j = 0; j < 4; j++)
                {
                    totalMes += vendas[i, j];
                }
                Console.WriteLine("O resultado do mês de {0} foi de: R$ {1}", meses[i], totalMes);
            }

            Console.WriteLine("\n\nA melhor semana para vendas no ano foi a {0}° semana", get_best_week(weekVal));
        }

        /***********
         * Questão 02
         * **********/
        static void questao_02()
        {

            int lastValue = 0;
            int valInputed = 0;
            int biggestSequence = 0;

            while (valInputed != -1)
            {

                Console.WriteLine("\n\nDigite um valor a ser adicionado à sequência: ");
                valInputed = int.Parse(Console.ReadLine());

                if (valInputed != -1)
                {

                    if (lastValue < valInputed)
                    {
                        biggestSequence++;
                    }
                    else
                    {
                        biggestSequence = 1;
                    }

                    lastValue = valInputed;
                }
            }

            Console.WriteLine("\nA maior sequencia de números crescentes possui {0} elementos", biggestSequence);
        }

        /***********
         * Questão 03
         * **********/
        static void questao_03()
        {
            int n = -1, validation = 0, auxOperation = 0;
            double P = 0;

            while( validation == 0)
            {
                Console.WriteLine("\n\nDigite um valor para N:");
                n = int.Parse(Console.ReadLine());

                if (!(n % 2 == 0))
                {
                    validation = 1;
                }
                else
                {
                    Console.WriteLine("\n\nVocê precisa digitar um número IMPAR para continuar");
                }
            }

            for( int i = 1; i <= n; i += 2)
            {
                if( auxOperation % 2 == 0 )
                {
                    P += ( 4.0 / i );
                }
                else
                {
                    P -= ( 4.0 / i );
                }
                auxOperation++;
            }

            Console.WriteLine("\n\nO valor de P é: {0}", P);

        }

        /***********
         * Questão 04
         * **********/

        static void sum_array( double[] x, double[] y, double[] result )
        {
            for( int i = 0; i < 5; i++)
            {
                result[i] = (x[i] + y[i]);
            }
        }

        static void prod_array( double[] x, double[] y, double[] result)
        {
            for ( int i = 0; i < 5; i++)
            {
                result[i] = x[i] * y[i];
            }
        }

        static void dif_array( double[] x, double[] y, double[] result)
        {
            for( int i = 0; i < 5; i++)
            {
                result[i] = x[i] - y[i];
            }
        }

        static void it_array( double[] x, double[] y, double[] result)
        {

            int iterator = 0;

            for( int i = 0; i < 5; i++)
            {
                for( int j = 0; j < 5; j++)
                {
                    if( x[i] == y[j])
                    {
                        result[iterator] = x[i];
                        iterator++;
                    }
                }
            }
        }

        static void uni_array( double[] x, double[] y, double[] result)
        {

            int iterator = 5;
            bool validation = false;
            
            for( int i = 0; i < 5; i++)
            {
                result[i] = x[i];
            }

            for (int i = 0; i < 5; i++)
            {

                validation = false;
                for (int j = 0; j < 5; j++)
                {
                    if (x[j] == y[i])
                    {
                        validation = true;
                    }
                }

                if( !validation)
                {
                    result[iterator] = y[i];
                    iterator++;
                }
            }
        }
        static void questao_04()
        {

            double[] x = new double[5];
            double[] y = new double[5];

            // Arrays returns
            double[] sumArr = new double[5], prodArr = new double[5], difArr = new double[5], intArr = new double[5], uniArr = new double[10];

            // Fill x vetor
            for( int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nDigite um valor para a posição {0} do vetor X: ", ( i + 1 ));
                x[i] = double.Parse(Console.ReadLine());
            }

            // Fill x vetor
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nDigite um valor para a posição {0} do vetor Y: ", (i + 1));
                y[i] = double.Parse(Console.ReadLine());
            }

            // Exec functions
            sum_array(x, y, sumArr);
            prod_array( x,y,prodArr );
            dif_array(x,y,difArr);
            it_array(x, y, intArr);
            uni_array(x, y, uniArr);

            foreach (double value in sumArr)
            {
                Console.WriteLine(value);
            }

        }

        static void Main(string[] args)
        {

            int q = -1;

            while (q != 0)
            {
                Console.WriteLine("\n\n Digite a questão que deseja executar: \n( 1 ) Questão 1\n( 2 ) Questão 2\n( 3 ) Questão 3\n( 0 ) Sair");
                q = int.Parse(Console.ReadLine());

                switch (q)
                {
                    case 1:
                        questao_01();
                        break;
                    case 2:
                        questao_02();
                        break;
                    case 3:
                        questao_03();
                        break;
                    case 4:
                        questao_04();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("\n\n Nenhuma opção valida encontrada. Por favor, tente novamente");
                        break;
                }
            }


        }

    }
}
