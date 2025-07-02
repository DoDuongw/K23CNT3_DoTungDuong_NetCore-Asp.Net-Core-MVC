using System;
using System.Collections.Generic;

namespace Dtd2310900027.Models;

public partial class DtdEmployee
{
    public int DtdEmpId { get; set; }

    public string? DtdEmpName { get; set; }

    public string? DtdEmpLevel { get; set; }

    public DateOnly? DtdEmpStartDate { get; set; }

    public bool? DtdEmpStatus { get; set; }
}
