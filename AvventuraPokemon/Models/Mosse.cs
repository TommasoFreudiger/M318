using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvventuraPokemon.Models
{
    public class Mosse
    {
        #region ====01==== Costanti & Statici ==========
        #endregion

        #region ====02==== Membri & Proprietà ==========

        public string Nome { get; set; }
        public int Potenza { get; set; }
        public string Tipo { get; set; }

        #endregion

        #region ====03==== Costruttori =================

        public Mosse(string nome, int potenza, string tipo)
        {
            Nome = nome;
            Potenza = potenza;
            Tipo = tipo;
        }

        #endregion

        #region ====04==== Metodi Private ==============
        #endregion

        #region ====05==== Metodi Public ===============
        #endregion

    }
}
