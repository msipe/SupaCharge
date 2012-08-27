﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupaCharge.Core.Converter {
  public class ValueConverter {
    public T Get<T>(object val) {
      return (T) Convert.ChangeType(val, typeof(T));
    }

    public T Get<T>(object val, T defVal) {
      try {
        var result = (T)Convert.ChangeType(val, typeof(T));
      }

      catch {
        return defVal;
      }

      return (T) Convert.ChangeType(val, typeof(T));
    }

    //public T Get<T>(object val, T defval) 
  }
}
