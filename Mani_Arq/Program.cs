using System;
using Mani_Arq.Helper;
using System.IO;
using System.Collections.Generic;

namespace Mani_Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta 1");
            var caminhoFile = Path.Combine(caminho, "Arquivo-test-stream.txt");
            var listaString = new List<string> {"linha 1","linha 2","linha 3","linha 4","linha 5"};
            var listaString2 = new List<string> {"linha 6","linha 7","linha 8","linha 9", "linha 10"};
            var novoCaminhoFile = Path.Combine(caminho, "Pasta 2", "Arquivo-test-stream.txt");
            var caminhoFileTest = Path.Combine(caminho, "Arquivo-test.txt");
            var caminhoFileTestCopia = Path.Combine(caminho, "Arquivo-test-bkp.txt");

            FileHelper  rep = new FileHelper();

            //lista diretorios
            //rep.ListaDiretorios(caminho);

            //lista arquivos
            //rep.ListaArquivosDiretorios(caminho);

            //Console.WriteLine("Criando diretorio: "+ caminhoPathCombine);
            //rep.CriarDirtorio(caminhoPathCombine);

            // apagra diretorio
            //rep.ApagarDiretorio(caminhoPathCombine, true);

            // cirar arquivos testo class Fie
            //rep.CriarArquivoTxt(caminhoFile, "Capuvara Boy");

            //rep.CreaArquivoStram(caminhoFile, listaString);
            //rep.AdirionarTextoStream(caminhoFile, listaString2);

            // Lendo arquivos
            //rep.LerArquivoStream(caminhoFile);

            //rep.MoverArquivo(caminhoFile, novoCaminhoFile, false);
            //rep.CopiarArquivo(caminhoFileTest, caminhoFileTestCopia, false);
            rep.DeletarFile(caminhoFileTestCopia);
        }
    }
}
