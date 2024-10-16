using System;
using System.Collections.Generic;

namespace Parcial202419200088.Data;

public partial class Attendees
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Level { get; set; } = null!;
}
