using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperaçõesLista
    {
        public void ImprimirListaString(List<string> lista){
            for (var i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice {i}, Valor : {lista[i]}");
            }
        }
    }
}