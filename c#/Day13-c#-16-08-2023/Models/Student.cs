using System;
using System.Collections.Generic;

namespace JWT_Auth.Models;

public partial class Student
{
    public int Rollno { get; set; }

    public string Studentame { get; set; } = null!;

    public string Addr { get; set; } = null!;

    public long Phno { get; set; }
}
