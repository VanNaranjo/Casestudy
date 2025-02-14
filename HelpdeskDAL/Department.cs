﻿using System;
using System.Collections.Generic;

namespace HelpdeskDAL;

public partial class Department : HelpdeskEntity
{
    //public int Id { get; set; }

    public string? DepartmentName { get; set; }

    //public byte[] Timer { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
