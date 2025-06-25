using System;
using System.Collections.Generic;

namespace DtdLesson10.Models;

public partial class DtdPost
{
    public int DtdId { get; set; }

    public string DtdTitle { get; set; } = null!;

    public string? DtdImage { get; set; }

    public string? DtdContent { get; set; }

    public bool DtdStatus { get; set; }
}

