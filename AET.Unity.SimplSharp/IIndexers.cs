﻿namespace Unity.SimplSharp {
  public interface IIndexer<T> {
    T this[int index] { set; }
  }
}

