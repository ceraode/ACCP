using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class JG
    {
        public JG() { }
        public JG(string name, string miaoshu, int jiage)
        {
            this.jgName = name;
            this.jgMiaoshu = miaoshu;
            this.jgJiage = jiage;
        }

        //名称
        private string jgName;
        public string JGName1
        {
          get { return jgName; }
          set { jgName = value; }
        }

        //描述
        private string jgMiaoshu;
        public string JGMiaoshu
        {
          get { return jgMiaoshu; }
          set { jgMiaoshu = value; }
        }

        //价格
        private int jgJiage;
        public int JgJiage
        {
          get { return jgJiage; }
          set { jgJiage = value; }
        }

    }
}
