using AvventuraPokemon.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AvventuraPokemon;

public partial class PokedexPage : ContentPage
{
    List<Pokemon> pokemons = new List<Pokemon>();
    List<Pokemon> favoritePokemons = new List<Pokemon>(); // Lista dei Pokémon preferiti
    Pokemon pokemonSelected;
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

    public PokedexPage()
    {
        InitializeComponent();

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

    private void PickPokemonSelezionato(object sender, EventArgs e)
    {
        // Seleziona il Pokémon dalla lista
        pokemonSelected = (Pokemon)pickPokemon.SelectedItem;

        // Mostra i dettagli del Pokémon
        imagePath.Source = pokemonSelected.ImmaginePath;
        entNome.Text = pokemonSelected.Nome;
        entVita.Text = pokemonSelected.VitaMassima.ToString();
        entLivello.Text = pokemonSelected.Livello.ToString();
        entMosse.Text = pokemonSelected.MossePreview;
    }

    private void OnAddToFavoritesClicked(object sender, EventArgs e)
    {
        // Aggiungi il Pokémon selezionato alla lista dei preferiti, se non è già presente
        if (pokemonSelected != null && !favoritePokemons.Contains(pokemonSelected))
        {
            favoritePokemons.Add(pokemonSelected);
            pickFavorites.ItemsSource = null; 
            pickFavorites.ItemsSource = favoritePokemons; 
            DisplayAlert("Successo", $"{pokemonSelected.Nome} è stato aggiunto ai preferiti!", "OK");
        }
        else
        {
            DisplayAlert("Errore", "Seleziona un Pokémon prima di aggiungerlo ai preferiti.", "OK");
        }
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

    private void pickFavorites_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Mostra i dettagli del Pokémon
        imagePath.Source = pokemonSelected.ImmaginePath;
        entNome.Text = pokemonSelected.Nome;
        entVita.Text = pokemonSelected.VitaMassima.ToString();
        entLivello.Text = pokemonSelected.Livello.ToString();
        entMosse.Text = pokemonSelected.MossePreview;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

}


