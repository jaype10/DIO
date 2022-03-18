using System;
using System.Collections.Generic;
using Colecoes.Helper;


namespace Colecoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("for");
            
            // for (var i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("foreach");

            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

            // int[,] matrix = new int[4, 2]{
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (var i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (var j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matrix[i, j]);
            //     }
            // }

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5]{ 6, 3, 8, 1, 9 };
            // int[] arrayCopia = new int[10];

            // System.Console.WriteLine("Array Original: ");
            // op.ImprimirArray(array);

            // op.OrdernarBubbleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia: ");
            // op.ImprimirArray(arrayCopia);

            //int valorProcurado = 8;
            // bool existe = op.Existe(array, valorPorcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorPorcurado);
            // }else{
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorPorcurado);
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorPorcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que {0}", valorPorcurado);
            // }else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorPorcurado);
            // }

            // int valorAchado = op.ObterValor(array, valorPorcurado);

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encotrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encotrei o valor");
            // }

            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice > -1){
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }else{
            //     System.Console.WriteLine("valor não existente no array");
            // }

            // string[] arrayString = op.ConverterParaArrayString(array);

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // OperaçõesLista oplista = new OperaçõesLista();

            // List<string> estados = new List<string>{"DF", "SP", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // oplista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemnto");
            // estados.Remove("SP");

            // estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // oplista.ImprimirListaString(estados);

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("João");
            // fila.Enqueue("Paulo");
            // fila.Enqueue("André");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // Dictionary<string, string> estados = new Dictionary<string, string>();
            // estados.Add("DF", "Distrito Federal");
            // estados.Add("SP", "São Paulo");
            // estados.Add("BA", "Bahia");

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "SC";

            //var teste = estados["SC"];

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }else
            // {
            //     System.Console.WriteLine($"Chave: {valorProcurado} não existe no dicionário");
            // }

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualização";

            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]);
            int[] arrayNumeros = new int[10] {100, 1, 4, 8, 0, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();


            System.Console.WriteLine($"Mínimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");  
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");  
            // var numerosParesQuery =
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Números pares query: " +string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));
         }
    }
}