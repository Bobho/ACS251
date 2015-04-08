using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Componet
{
    public interface IObserver
    {
        string Name { get; set; }

        int 生命值 { get; }

        bool IsAdded { get; set; }

        string helpDescription { get; set; }

        void Help();

        void BeAttecked(ConcreateAllControlCenter acc);

        string PlayerDied();
    }
}