using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Componet
{
    public interface AllControlCenter
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void Notify(IObserver name);
    }
}