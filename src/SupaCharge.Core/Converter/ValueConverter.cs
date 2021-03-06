﻿using System;

namespace SupaCharge.Core.Converter {
  public class ValueConverter {
    public T Get<T>(object val) {
      return (T)Convert.ChangeType(val, typeof(T));
    }

    public T Get<T>(object val, T defVal) {
      if (val == null)
        return defVal;
      return (T)Convert.ChangeType(val, typeof(T));
    }
  }
}