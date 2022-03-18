using System;
using ExemploConstrutores.models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        public static void Main(string[] args)
        {
            // Aluno p1 = new Aluno("João Paulo", "Jaype", "Programação");
            // p1.Apresentar();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Data data = new Data();
            // //data.SetMes(2);

            // data.Mes =13;
            // //System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Operacao op = new Operacao(Calculadora.Somar);
            // Operacao op1 = Calculadora.Subtrair;
            // op += Calculadora.Subtrair;

            // op.Invoke(10, 10);

            // op1(10,10);

            Matematica m = new Matematica(10, 20);
            m.Somar();
        }
    }
}