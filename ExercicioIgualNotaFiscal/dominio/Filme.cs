using System;
using System.Collections.Generic;

namespace ExercicioIgualNotaFiscal.dominio
{
    public class Filme
    {

        public int codigoFilme { get; set; }
        public string tituloFilme { get; set; }
        public int anoFilme { get; set; }
        public static List<ArtistasDoFilme> listaDeArtistasDoFilme { get; set; }

        public Filme(int codigoFilme, string tituloFilme, int anoFilme)
        {
            this.codigoFilme = codigoFilme;
            this.tituloFilme = tituloFilme;
            this.anoFilme = anoFilme;
            listaDeArtistasDoFilme = new List<ArtistasDoFilme>();
        }

        public double custoTotalDoFilme(){

            double soma = 0;

            for (int i = 0; i < listaDeArtistasDoFilme.Count; i++){
                soma += listaDeArtistasDoFilme[i].cacheFinalComDesconto();
            }

            return soma;

        }

        public override string ToString()
        {
            String s = "Filme: " + codigoFilme + ", TItulo: " + tituloFilme + ", Ano: " + anoFilme + "\n Participacoes: \n";

            for (var i = 0; i < listaDeArtistasDoFilme.Count; i++){
                s += listaDeArtistasDoFilme[i] + "\n";
            }

            s += "Custo total do filme: " + custoTotalDoFilme() + "\n";

            return s;
        }


    }
}
