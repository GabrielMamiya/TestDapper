using System;
using System.Collections.Generic;
using ExercicioIgualNotaFiscal.dominio;

namespace ExercicioIgualNotaFiscal
{
    class MainClass
    {

        public static List<Artista> listaDeArtistas = new List<Artista>();
        public static List<Filme> listaDeFilmes = new List<Filme>();

        public static void Main(string[] args)
        {

            listaDeArtistas.Add(new Artista(101, "Scarlett Johansson", 4000000));
            listaDeArtistas.Add(new Artista(102, "Chris Evans", 2500000));
            listaDeArtistas.Add(new Artista(103, "Robert Downey Jr.", 3000000));
            listaDeArtistas.Add(new Artista(104, "Morgan Freeman", 4000000));

            int opcao = 0;

            while(opcao != 5){

                Tela.exibirMenu();
                Console.Write("Escolha uma opcao: ");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1){
                    Console.WriteLine();
                    Console.WriteLine("Listagem de Artistas: ");
                    Tela.exibirArtistas();
                    Console.WriteLine();
                    opcao = 0;
                } else if(opcao == 2){
                    Tela.cadastrarArtistas();
                } else if(opcao == 3){
                    Tela.cadastrarFilme();
                } else if(opcao == 4){
                    Tela.mostrarDadosDoFilme();
                } else if(opcao == 5){
                    Console.WriteLine("Obrigado por usar o nosso programa!");
                }

            }
        }
    }
}
