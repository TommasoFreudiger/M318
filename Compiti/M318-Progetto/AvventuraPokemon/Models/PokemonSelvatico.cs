using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvventuraPokemon.Models
{
    public class PokemonSelvatico
    {
        #region ====01==== Costanti & Statici ==========
        #endregion

        #region ====02==== Membri & Proprietà ==========

        public string Nome { get; set; }
        public int Livello { get; set; }
        public int Vita { get; set; }
        public List<Mosse> Mosse { get; set; }

        #endregion

        #region ====03==== Costruttori =================

        public PokemonSelvatico(string nome, int livello, int vita, List<Mosse> mosse)
        {
            Nome = nome;
            Livello = livello;
            Vita = vita;
            Mosse = mosse;
        }

        #endregion

        #region ====04==== Metodi Private ==============
        #endregion

        #region ====05==== Metodi Public ===============
        #endregion

    }
}
