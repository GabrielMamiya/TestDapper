using System;
using System.Collections.Generic;

namespace ExercicioIgualNotaFiscal.dominio
{
    public class ArtistasDoFilme
    {

        public double desconto { get; set; }
        public Artista artista { get; set; }
        public List<ArtistasDoFilme> listaDeArtistasDoFilme { get; set; }

        public ArtistasDoFilme(double desconto, Artista artista)
        {
            this.desconto = desconto;
            this.artista = artista;
        }

        public double cacheFinalComDesconto(){
            return artista.cacheArtista - desconto;
        }

        public override string ToString()
        {
            return artista.nomeArtista + ", Cache: " + artista.cacheArtista + ", Desconto: " + desconto + ", Custo: " + cacheFinalComDesconto();
        }


    }
}
