using System;
using System.Collections.Generic;

namespace ZH2_proba1.Models;

public partial class Game
{
    public int GameSk { get; set; }

    public string Nev { get; set; } = null!;

    public byte KategoriaFk { get; set; }

    public int? MinLetszam { get; set; }

    public int? MaxLetszam { get; set; }

    public int ArFt { get; set; }

    public int? IdotartamPerc { get; set; }

    public int? SzuksegesEletkor { get; set; }

    public virtual Kategorium KategoriaFkNavigation { get; set; } = null!;

    public virtual ICollection<Rendele> Rendeles { get; set; } = new List<Rendele>();
}
