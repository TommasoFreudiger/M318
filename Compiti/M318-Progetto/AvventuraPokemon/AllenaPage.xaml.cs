using AvventuraPokemon.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace AvventuraPokemon
{
    public partial class AllenaPage : ContentPage
    {
        public ObservableCollection<PokemonSelvatico> PokemonSelvatici { get; set; }
        List<Pokemon> pokemons = new List<Pokemon>();
        Pokemon pikachu;
        Pokemon charmender;
        Pokemon bulbasaur;
        Pokemon squirtle;
        Pokemon jigglypuff;
        Pokemon meowth;
        Pokemon eevee;
        Pokemon pidgey;
        Pokemon rattata;
        Pokemon zubat;
        Pokemon snorlax;
        Pokemon pokemonSelected;
        private Random random = new Random();

        public AllenaPage()
        {
            InitializeComponent();

            PokemonSelvatici = new ObservableCollection<PokemonSelvatico>
            {
            new PokemonSelvatico("Rattata", 3, 40, new List<Mosse> { new Mosse("Morso", 30, "Normale") }),
            new PokemonSelvatico("Zubat", 5, 50, new List<Mosse> { new Mosse("Azione", 20, "Volante") }),
            new PokemonSelvatico("Geodude", 7, 60, new List<Mosse> { new Mosse("Rollout", 40, "Roccia") }),
            new PokemonSelvatico("Pidgey", 4, 45, new List<Mosse> { new Mosse("Puntura", 25, "Normale") }),
            new PokemonSelvatico("Caterpie", 2, 30, new List<Mosse> { new Mosse("Ragno", 15, "Coleottero") }),
            new PokemonSelvatico("Oddish", 6, 55, new List<Mosse> { new Mosse("Assorbimento", 20, "Erba") }),
            new PokemonSelvatico("Rattata", 3, 40, new List<Mosse> { new Mosse("Morso", 30, "Normale") }),
            new PokemonSelvatico("Magnemite", 8, 60, new List<Mosse> { new Mosse("Turbine Elettrico", 40, "Elettro") }),
            new PokemonSelvatico("Poliwag", 5, 45, new List<Mosse> { new Mosse("Sberla d'Acqua", 30, "Acqua") }),
            new PokemonSelvatico("Sandshrew", 4, 50, new List<Mosse> { new Mosse("Attacco Rapido", 20, "Normale") }),
            };

            try
            {
                pikachu = new Pokemon("Pikachu", "pikachu.png", 5, 100, 200, 35,
                new List<Mosse>
                {
                    new Mosse("Fulmine", 40, "Elettrico"),
                    new Mosse("Coda di Ferro", 35, "Acciaio")
                },
                10, 35);

                charmender = new Pokemon("Charmander", "charmander.png", 8, 300, 500, 39,
                new List<Mosse>
                {
                    new Mosse("Lanciafiamme", 50, "Fuoco"),
                    new Mosse("Graffio", 20, "Normale")
                },
                12, 39);

                bulbasaur = new Pokemon("Bulbasaur", "bulbasaur.png", 6, 150, 300, 45,
                new List<Mosse>
                {
                    new Mosse("Frustata", 25, "Erba"),
                    new Mosse("Fogliamele", 30, "Erba")
                },
                15, 45);

                squirtle = new Pokemon("Squirtle", "squirtle.png", 4, 120, 250, 40,
                new List<Mosse>
                {
                    new Mosse("Idropompa", 40, "Acqua"),
                    new Mosse("Morso", 30, "Acqua")
                },
                8, 40);

                jigglypuff = new Pokemon("Jigglypuff", "jigglypuff.png", 10, 500, 600, 40,
                new List<Mosse>
                {
                    new Mosse("Canto", 0, "Normale"),
                    new Mosse("Sbattere", 25, "Normale")
                },
                20, 40);

                meowth = new Pokemon("Meowth", "meowth.png", 12, 700, 900, 50,
                new List<Mosse>
                {
                    new Mosse("Puntura", 35, "Normale"),
                    new Mosse("Zampata", 40, "Normale")
                },
                25, 50);

                eevee = new Pokemon("Eevee", "eevee.png", 5, 150, 300, 35,
                new List<Mosse>
                {
                    new Mosse("Attacco rapido", 30, "Normale"),
                    new Mosse("Fogliame", 35, "Erba")
                },
                15, 35);

                pidgey = new Pokemon("Pidgey", "pidgey.png", 3, 50, 150, 30,
                new List<Mosse>
                {
                    new Mosse("Attacco rapido", 20, "Normale"),
                    new Mosse("Ventagliata", 40, "Volante")
                },
                5, 30);

                rattata = new Pokemon("Rattata", "rattata.png", 3, 70, 180, 30,
                new List<Mosse>
                {
                    new Mosse("Morsicatura", 30, "Normale"),
                    new Mosse("Sgranocchio", 40, "Normale")
                },
                6, 30);

                zubat = new Pokemon("Zubat", "zubat.png", 6, 150, 400, 35,
                new List<Mosse>
                {
                    new Mosse("Velenospina", 35, "Veleno"),
                    new Mosse("Sbatacchio", 40, "Volante")
                },
                8, 35);

                snorlax = new Pokemon("Snorlax", "snorlax.png", 50, 5000, 10000, 160,
                new List<Mosse>
                {
                    new Mosse("Mangiatutto", 80, "Normale"),
                    new Mosse("Riposo", 0, "Normale")
                },
                40, 160);
            }
            catch (ArgumentOutOfRangeException ae) 
            {
                entNome.Text = ae.Message;
            }
            PopulateList();
        }

        private async void OnAllenatiClicked(object sender, EventArgs e)
        {
            if (pokemonSelected == null)
            {
                await DisplayAlert("Errore", "Seleziona un Pokémon prima di allenarti.", "OK");
                return;
            }

            // Scegli un Pokémon selvatico casuale
            var random = new Random();
            var pokemonSelvatico = PokemonSelvatici[random.Next(PokemonSelvatici.Count)];

            // Chiedi se vuoi combattere
            bool vuoiCombattere = await DisplayAlert(
                "Vuoi combattere?",
                $"Hai incontrato un {pokemonSelvatico.Nome} di livello {pokemonSelvatico.Livello}!\n" +
                $"Vuoi iniziare la battaglia?",
                "Sì", "No");

            if (!vuoiCombattere)
            {
                await DisplayAlert("Battaglia annullata", "Hai deciso di scappare.", "OK");
                return;
            }

            // Inizia la battaglia
            string logBattaglia = $"Hai incontrato un {pokemonSelvatico.Nome} di livello {pokemonSelvatico.Livello}!\n";
            int turno = 1;

            while (pokemonSelected.Vita > 0 && pokemonSelvatico.Vita > 0)
            {
                // Pokémon selezionato usa una mossa
                var mossaUsata = pokemonSelected.Mosse[random.Next(pokemonSelected.Mosse.Count)];
                int dannoInflitto = mossaUsata.Potenza;
                pokemonSelvatico.Vita -= dannoInflitto;

                logBattaglia += $"\nTurno {turno}: {pokemonSelected.Nome} usa {mossaUsata.Nome} e infligge {dannoInflitto} danni a {pokemonSelvatico.Nome}!";
                if (pokemonSelvatico.Vita <= 0)
                {
                    logBattaglia += $"\n{pokemonSelvatico.Nome} è stato sconfitto!";
                    break;
                }

                // Pokémon selvatico usa una mossa
                var mossaSelvatico = pokemonSelvatico.Mosse[random.Next(pokemonSelvatico.Mosse.Count)];
                int dannoSubito = mossaSelvatico.Potenza;
                pokemonSelected.Vita -= dannoSubito;

                logBattaglia += $"\n{pokemonSelvatico.Nome} usa {mossaSelvatico.Nome} e infligge {dannoSubito} danni a {pokemonSelected.Nome}!";
                if (pokemonSelected.Vita <= 0)
                {
                    logBattaglia += $"\n{pokemonSelected.Nome} è stato sconfitto!";
                    break;
                }

                turno++;
            }

            // Risultato della battaglia
            var esperienzaGuadagnata = pokemonSelvatico.Livello * 20;
            if (pokemonSelected.Vita > 0)
            {
                pokemonSelected.Esperienza += esperienzaGuadagnata;

                if(esperienzaGuadagnata >= pokemonSelected.EsperienzaXLivello)
                {
                    pokemonSelected.Livello++;
                    pokemonSelected.EsperienzaXLivello += 50;
                    pokemonSelected.Esperienza = 0;
                    pokemonSelected.Vita += 10;
                    pokemonSelected.VitaMassima += 10;
                    logBattaglia += $"\n\n{pokemonSelected.Nome} ha vinto la battaglia! Livello aumentato a {pokemonSelected.Livello} e vita ripristinata parzialmente!";
                }
                else
                {
                    logBattaglia += $"\n\n{pokemonSelected.Nome} ha vinto la battaglia!";
                }
            }
            else
            {
                logBattaglia += $"\n\nHai perso la battaglia. {pokemonSelected.Nome} ha bisogno di cure!";
                pokemonSelected.Vita = 0;
            }

            // Mostra il log della battaglia
            await DisplayAlert("Risultato della Battaglia", logBattaglia, "OK");

            UpdatePokemonDetails();
        }



        private void OnCuraClicked(Object sender, EventArgs e)
        {
            if (pokemonSelected == null)
            {
                DisplayAlert("Errore", "Seleziona un Pokémon prima di curarlo.", "OK");
                return;
            }

            pokemonSelected.Vita = pokemonSelected.VitaMassima; // Ripristina la vita al massimo
            DisplayAlert("Cura", $"{pokemonSelected.Nome} è stato curato alla massima vita.", "OK");

            // Aggiorna i dettagli del Pokémon
            UpdatePokemonDetails();
        }

        private void pickPokemon_Selected(object sender, EventArgs e)
        {
            pokemonSelected = (Pokemon)pickPokemon.SelectedItem;
            UpdatePokemonDetails();
        }

        private void PopulateList()
        {
            pokemons.Add(pikachu);
            pokemons.Add(charmender);
            pokemons.Add(bulbasaur);
            pokemons.Add(squirtle);
            pokemons.Add(jigglypuff);
            pokemons.Add(meowth);
            pokemons.Add(eevee);
            pokemons.Add(pidgey);
            pokemons.Add(rattata);
            pokemons.Add(zubat);
            pokemons.Add(snorlax);
            pickPokemon.ItemsSource = pokemons;
        }

        private void UpdatePokemonDetails()
        {
            if (pokemonSelected != null)
            {
                imagePath.Source = pokemonSelected.ImmaginePath;
                entNome.Text = pokemonSelected.Nome;
                entVita.Text = pokemonSelected.Vita.ToString();
                entLivello.Text = pokemonSelected.Livello.ToString();
                entMosse.Text = pokemonSelected.MossePreview;
            }
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
