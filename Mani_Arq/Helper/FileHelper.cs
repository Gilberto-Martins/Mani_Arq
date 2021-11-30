using System.IO;
using System;
using System.Collections.Generic;

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

        //criando diretorio e sub diretorio e apagar diretorio

        public void CriarDirtorio (string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio (string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        //criando arquivo
        public void CriarArquivoTxt(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
               File.WriteAllText(caminho, conteudo); 
            }
        }

        // Craindo arquivo utilizando stream
        public void CreaArquivoStram (string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }  
        }

        //adicionar texto a arquivos exitentes
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdirionarTextoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        //Lendo aquivos

        public void LerArquivo (string caminho)
        {
            var ler = File.ReadAllLines(caminho);

            foreach (var linha in ler)
            {
                Console.WriteLine(linha);
            }
        }

        //mais recomendado fazer a leitura pelo metodo stream
        public void LerArquivoStream (string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     Console.WriteLine(linha);
                }
            }
        }

        //mover compiar e apagar o nome de um arquivo
        public void MoverArquivo (string caminho, string novocaminho, bool sobrescrever)
        {
            File.Move(caminho, novocaminho, sobrescrever);
        }

        public void CopiarArquivo (string caminho, string novocaminho, bool sobrescrever)
        {
            File.Copy(caminho, novocaminho, sobrescrever);
        }

        public void DeletarFile (string caminho)
        {
            File.Delete(caminho);
        }
    }
}