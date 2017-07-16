﻿using System.Collections.Generic;

public class Trainer
{
    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }
}