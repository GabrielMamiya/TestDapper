using System;
namespace ExercicioIgualNotaFiscal.dominio
{
    public class Artista
    {
        public int codigoArtista { get; set; }
        public string nomeArtista { get; set; }
        public double cacheArtista { get; set; }

        public Artista(int codigoArtista, string nomeArtista, double cacheArtista)
        {
            this.codigoArtista = codigoArtista;
            this.nomeArtista = nomeArtista;
            this.cacheArtista = cacheArtista;
        }

        public override string ToString()
        {
            return codigoArtista + ", " + nomeArtista + ", Cache: " + cacheArtista;
        }
    }
}
