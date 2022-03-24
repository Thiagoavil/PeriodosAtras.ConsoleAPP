using System;

namespace PeriodosAtras
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            DateTime dataBase;
            DateTime dataDigitada;
            int diferencaAno = 0;
            int diferencaMes = 0;
            int diferencaDia = 0;
            string opcao = "1";

            Console.WriteLine("Digite a data base:  (dd/mm/aaaa)");
            dataBase =DateTime.Parse(Console.ReadLine());

            while (true)
            {
                

                Console.WriteLine("Digite a data de comparação: ");
                dataDigitada = DateTime.Parse(Console.ReadLine());

                if (dataBase.Year == dataDigitada.Year)
                {
                    diferencaAno = 0;

                    if(dataBase.Month==dataDigitada.Month)
                    {
                        diferencaMes = 0;
                        if(dataBase.Day==dataDigitada.Day)
                        {
                            diferencaDia = 0;
                        }
                        else
                        {
                            diferencaDia=CalculaDia(dataBase, dataDigitada, diferencaDia);

                        }
                    }
                    else
                    {
                        diferencaMes=CalculaMes(dataBase, dataDigitada,diferencaMes);
                        if (dataBase.Day == dataDigitada.Day)
                        {
                            diferencaDia = 0;
                        }
                        else
                        {
                            diferencaDia=CalculaDia(dataBase, dataDigitada, diferencaDia);

                        }
                    }
                }
                else
                {
                    diferencaAno = CalculaAno(dataBase,dataDigitada,diferencaAno);
                    
                    if (dataBase.Month == dataDigitada.Month)
                    {
                        diferencaMes = 0;
                        if (dataBase.Day == dataDigitada.Day)
                        {
                            diferencaDia = 0;
                        }
                        else
                        {
                            diferencaDia= CalculaDia(dataBase, dataDigitada,diferencaDia);
                        }
                    }
                    else
                    {
                        diferencaMes=CalculaMes(dataBase, dataDigitada, diferencaMes);

                        if (dataBase.Day == dataDigitada.Day)
                        {
                            diferencaDia = 0;
                        }
                        else
                        {
                            diferencaDia=CalculaDia(dataBase, dataDigitada,diferencaDia);
                        }
                    }
                }

                Console.WriteLine("Dia: " + diferencaDia + "," + 
                                   "Mes: " + diferencaMes + "," + 
                                    "Ano: " + diferencaAno + ".");
                Console.WriteLine("");


                Console.WriteLine("usar outro valor para comparação?");
                Console.WriteLine("S- Para continuar\nX- Para sair");
                opcao=Console.ReadLine().ToUpper();


                if(opcao=="X")
                {
                    break;
                }
            }
            







        }

        static int CalculaDia(DateTime dataBase, DateTime dataDigitada,int diferencaDia)
        {
            diferencaDia = dataBase.Day- dataDigitada.Day ;
            if(diferencaDia<0)
            {
                diferencaDia *= -1;
            }
            return diferencaDia;
        }

        static int CalculaMes(DateTime dataBase, DateTime dataDigitada,int diferencaMes)
        {
            diferencaMes = dataBase.Month- dataDigitada.Month;
            if (diferencaMes < 0)
            {
                diferencaMes *= -1;
            }
            return diferencaMes;
        }

        static int CalculaAno(DateTime dataBase, DateTime dataDigitada,int diferencaAno)
        {
            diferencaAno = dataBase.Year-dataDigitada.Year ;
            if (diferencaAno < 0)
            {
                diferencaAno *= -1;
            }
            return diferencaAno;
        }



    }
}
