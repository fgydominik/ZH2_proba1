using System;
using System.Collections.Generic;

namespace ZH2_proba1.Models;

public partial class Rendele
{
    public int RendelesId { get; set; }

    public int GameFk { get; set; }

    public int MennyisegDb { get; set; }

    public int FizetendoFt { get; set; }

    public virtual Game GameFkNavigation { get; set; } = null!;
}
