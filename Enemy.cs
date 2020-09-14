using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Task1
{
    class Enemy : Character
    {
        protected Random r = new Random();
        public Enemy(int x, int y) : base(x, y)
        {
            
        }

        public Enemy(int Hp, int maxHp, int Damage, int x, int y) : base(Hp, maxHp, Damage, x, y)
        {

        }

        public override string ToString()
        {
            return "Name {0} {1} {2}" + X_Pos, Y_Pos, Damage;
        }
    }
}
