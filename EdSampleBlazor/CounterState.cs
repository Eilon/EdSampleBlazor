using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdSampleBlazor
{
    public class CounterState
    {
        public int CounterValue { get; private set; }

        public event Action OnChanged;

        public void Increment()
        {
            CounterValue++;
            OnChanged?.Invoke();
        }
    }
}
