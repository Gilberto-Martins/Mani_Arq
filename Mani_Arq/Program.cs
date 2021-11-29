using System;
using Mani_Arq.Helper;

namespace Mani_Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";

            FileHelper  rep = new FileHelper();

            //lista diretorios
            //rep.ListaDiretorios(caminho);

            //lista arquivos
            rep.ListaArquivosDiretorios(caminho);
        }
    }
}
