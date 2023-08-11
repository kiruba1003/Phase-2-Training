using System;
using System.Collections.Generic;

namespace EFDDBF.Models;

public partial class Empm
{
    public int? Empno { get; set; }

    public string? Ename { get; set; }

    public string? Addr { get; set; }

    public int Deptno { get; set; }

    public virtual Dept DeptnoNavigation { get; set; } = null!;
}
