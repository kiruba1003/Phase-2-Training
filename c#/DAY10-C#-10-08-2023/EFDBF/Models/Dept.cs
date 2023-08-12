using System;
using System.Collections.Generic;

namespace EFDDBF.Models;

public partial class Dept
{
    public int Deptno { get; set; }

    public string? Dname { get; set; }

    public virtual Empm? Empm { get; set; }
}
