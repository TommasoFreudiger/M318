using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvventuraPokemon.Models
{
    public class Pokemon
    {
        #region ====01==== Costanti & Statici ==========
        #endregion

        #region ====02==== Membri & Proprietà ==========

        public string Nome { get; set; }
        public string ImmaginePath { get; set; }
        public int Vita { get; set; }
        public int Livello { get; set; }
        public int Esperienza { get; set; }
        public int EsperienzaXLivello { get; set; }
        public List<Mosse> Mosse { get; set; }
        public int Danno { get; set; }
        public string MossePreview => string.Join(", ", Mosse.Select(m => m.Nome));
        public int VitaMassima { get; set; }

        #endregion

        #region ====03==== Costruttori =================

        public Pokemon(string nome, string immaginePath, int livello, int esperienza, int esperienzaXLivello, int vita, List<Mosse> mosse,int danno, int vitaMassima)
        {
            Nome = nome;
            if (vitaMassima <= 0 || livello <= 0)
            {
                throw new ArgumentOutOfRangeException("Valori dei Pokemon non validi!");
            }
            ImmaginePath = immaginePath;
            Livello = livello;
            Esperienza = esperienza;
            EsperienzaXLivello = esperienzaXLivello;
            Vita = vita;
            Mosse = mosse;
            Danno = danno;
            VitaMassima = vitaMassima;
        }

        #endregion

        #region ====04==== Metodi Private ==============
        #endregion

        #region ====05==== Metodi Public ===============



        #endregion
    }
}

