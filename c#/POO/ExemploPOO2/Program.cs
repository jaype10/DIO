using System;
using System.IO;
using ExemploPOO2.Helper;
using ExemploPOO2.Interfaces;
using ExemploPOO2.Models;

namespace ExemploPOO2
{
        class Program
        {
            public static void Main(string[] args)
            {
                // Pessoa p1 = new Pessoa();
                // Aluno p1 = new Aluno();
                // p1.Nota = 10;
                // p1.Nome = "Bob";
                // p1.Idade = 20;
                // p1.Documento = "1234567";
                // p1.Apresentar();

                // Professor p2 = new Professor();
                // p2.Nome = "Felipe";
                // p2.Idade = 30;
                // p2.Documento="1234578";
                // p2.Salario = 3000;
                // p2.Apresentar();

                // Retangulo r = new Retangulo();
                // r.DefinirMedidas(30, 30);

                // System.Console.WriteLine($"Area: {r.ObterArea()}"); 
                
                // Retangulo r2 = new Retangulo();
                // r2.DefinirMedidas(0, 30);

                // System.Console.WriteLine($"Area: {r2.ObterArea()}"); 

                // Calculadora calc = new Calculadora();
                // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
                // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

                // Corrente c = new Corrente();
                // c.Creditar(100);
                // c.ExibirSaldo();

                // Computador comp = new Computador();
                // System.Console.WriteLine(comp.ToString());

                // ICalculadora calc = new Calculadora();
                // System.Console.WriteLine(calc.Somar(10, 20));

                var caminho = "C:\\TrabalhandoComArquivos";
                var pathCombine = Path.Combine(caminho, "teste1");
                var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
                var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
                var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
                var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
                var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
                var novoCaminhoArquivo = Path.Combine(caminho, "teste2", "arquivo-teste-stream.txt");

                FileHelper helper = new FileHelper();
                //helper.ListarDiretorios(caminho);
                //helper.ListarArquivosDiretorios(caminho);
                //helper.CriarDiretorio(pathCombine));
                //helper.ApagarDiretorio(pathCombine, true);
                //helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita de arquivo!");
                // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
                // helper.AdicionarArquivoTextoStream(caminhoArquivo, listaStringContinuacao);
                //helper.LerArquivoStream(caminhoArquivo);
                //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
                //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
                helper.DeletarArquivo(caminhoArquivoTesteCopia);
            }
        }
}