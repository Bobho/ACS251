using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Componet
{
    public class Players : IObserver
    {
        public string Name { get; set; }

        public string PlayerName { get; set; }

        private int life;

        public int 生命值
        {
            get
            {
                if (life >= 0)
                    return life;
                else
                    return 0;
            }
            private set { life = value; }
        }

        public int 等級 { get; set; }

        public string helpDescription { get; set; }

        public bool IsAdded { get; set; }

        public Players(string name, int _life, int level, bool isAdding)
        {
            this.Name = name;
            this.生命值 = _life;
            this.等級 = level;
            this.IsAdded = isAdding;
        }

        public void Help()
        {
            if (this.生命值 > 0)
            {
                string 求救訊號 = string.Format("{0},我被攻擊,快來救我\n", this.Name);
                helpDescription = 求救訊號;
            }
            else
            {
                helpDescription = PlayerDied();
            }
        }

        public void BeAttecked(ConcreateAllControlCenter acc)
        {
            this.life -= 100;
            acc.Notify(this);
        }

        public string PlayerDied()
        {
            string Description = string.Format("{0}已經掛了\n", this.Name);
            return Description;
        }

        public override string ToString()
        {
            string description = string.Format("姓名:{0}\r\n", this.Name);
            description += string.Format("生命值:{0}\r\n", this.生命值);
            description += string.Format("等級:{0}", this.等級);
            return description;
        }
    }
}