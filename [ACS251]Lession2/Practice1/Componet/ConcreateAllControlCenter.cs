using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Componet
{
    public class ConcreateAllControlCenter : AllControlCenter
    {
        private string AllName;

        public List<IObserver> players { get; private set; }

        public string 角色狀態;

        public ConcreateAllControlCenter()
        {
            players = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            o.IsAdded = true;
            players.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            o.IsAdded = false;
            players.Remove(o);
        }

        public void Notify(IObserver name)
        {
            foreach (object o in players)
            {
                if (!((IObserver)o).Name.Equals(name))
                    ((IObserver)o).Help();
            }
        }

        public override string ToString()
        {
            string description = string.Empty;
            foreach (IObserver player in players)
            {
                description += string.Format("現在隊員有{0}\n", player.Name);
            }
            return description;
        }

        public string RemoveDescription(IObserver o)
        {
            string description = string.Empty;
            description += string.Format("{0}離開隊伍了\n", o.Name);
            return description;
        }
    }
}