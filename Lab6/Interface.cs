using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
  interface INotifyable
  {
    void Notify(Action<string> output);
  }
}
