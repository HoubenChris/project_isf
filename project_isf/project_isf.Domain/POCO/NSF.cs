﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class NSF
  {
    public int NSFId { get; set; }
    public string RegionId { get; set; }
    public virtual Region Region { get; set; }
  }
}
