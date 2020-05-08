﻿using System;

namespace Unity.SimplSharp.Timer {
  public class TestsTimer : ITimer {

    public Action TimerCallback { private get; set; }
    
    public bool IsRunning { get; private set; }
    public long TimeoutMs { get; private set; }
    
    public void Start(long timeoutMs) {
      IsRunning = true;
      TimeoutMs = timeoutMs;
    }

    public void Restart() {  }

    public void TimerElapsed() {
      if (!IsRunning) return;
      IsRunning = false;
      TimerCallback();
    }
  }
}