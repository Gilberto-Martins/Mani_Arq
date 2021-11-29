using System.IO;
using System;

namespace Mani_Arq.Helper
{
    public class FileHelper
    {
        //vamos lista o diretorio
        public void ListaDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }
        
        
        //Lista arquivos
        public void ListaArquivosDiretorios(string caminho)
        {
            var retorneArquivos = Directory.GetFiles(caminho,"*2*",SearchOption.AllDirectories);

            foreach(var retorno in retorneArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        //criando diretorio
        
    }
}