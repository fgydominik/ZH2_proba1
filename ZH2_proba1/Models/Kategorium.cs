using System;
using System.Collections.Generic;

namespace ZH2_proba1.Models;

public partial class Kategorium
{
    public byte KategoriaSk { get; set; }

    public string KategoriaNev { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
