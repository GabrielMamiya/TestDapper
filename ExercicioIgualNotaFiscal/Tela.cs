using System;
using ExercicioIgualNotaFiscal.dominio;

namespace ExercicioIgualNotaFiscal
{
    public class Tela
    {
        
        public static void exibirMenu(){
            Console.WriteLine("1 - Listar Artistas");
            Console.WriteLine("2 - Cadastrar Artista");
            Console.WriteLine("3 - Cadastrar Filme");
            Console.WriteLine("4 - Mostrar Dados de um Filme");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
        }

        public static void exibirArtistas(){
            for (int i = 0; i < MainClass.listaDeArtistas.Count; i++){
                Console.WriteLine(MainClass.listaDeArtistas[i]);
            }
        }

        public static void cadastrarArtistas(){
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cache: ");
            double cache = double.Parse(Console.ReadLine());
            Artista a = new Artista(codigo, nome, cache);
            MainClass.listaDeArtistas.Add(a);
            Console.Clear();
        }

        public static void cadastrarFilme(){
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Codigo: ");
            int codFilme = int.Parse(Console.ReadLine());
            Console.Write("Titulo: ");
            string tituloFilme = Console.ReadLine();
            Console.Write("Ano: ");
            int anoFilme = int.Parse(Console.ReadLine());

            Console.Write("Quantas participacoes tem o filme? ");
            int participacoes = int.Parse(Console.ReadLine());
            // instanciar o filme
            MainClass.listaDeFilmes.Add(new Filme(codFilme, tituloFilme, anoFilme));

            for (int i = 0; i < participacoes; i++){
                Console.WriteLine("Digite os dados da " + (i+1) + " participacao: ");
                Console.Write("Artista (Codigo) : ");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = MainClass.listaDeArtistas.FindIndex(x => x.codigoArtista == codArtista);
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine());

                // artistas do filme
                ArtistasDoFilme a = new ArtistasDoFilme(desconto, MainClass.listaDeArtistas[pos]);
                Filme.listaDeArtistasDoFilme.Add(a);
            }
        }

        public static void mostrarDadosDoFilme(){

            Console.Write("Digite o codigo do filme: ");
            int codFilme = int.Parse(Console.ReadLine());

            int pos = MainClass.listaDeFilmes.FindIndex(x => x.codigoFilme == codFilme);

            Console.Write(MainClass.listaDeFilmes[pos]);

        }

    }
}
