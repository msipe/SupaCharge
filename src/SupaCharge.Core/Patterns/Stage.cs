﻿namespace SupaCharge.Core.Patterns {
  public abstract class Stage<T> {
    protected Stage(int priority) {
      Priority = priority;
    }

    public int Priority{get;private set;}
    public void Execute(CancelToken token, T context) {}
  }
}