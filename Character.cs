using System.Windows.Forms;

namespace Task1
{
    abstract class Character : Tile
    {
        private int hp;
        private int maxhp;
        private int damage;
        private string[] arrVision = new string[4];

        protected int Hp { get => hp; set => hp = value; }
        protected int Maxhp { get => maxhp; set => maxhp = value; }
        protected int Damage { get => damage; set => damage = value; }
        public string[] ArrVision { get => arrVision; set => arrVision = value; }

        public enum Movement { Idle, Up, Down, Left, Right }

        public Character(int x, int y) : base(x, y)
        {

        }

        public Character(int hp, int maxHp, int damage, int x, int y) : base(x, y)
        {
            this.hp = hp;
            this.maxhp = maxHp;
            this.damage = damage; 
        }

        public virtual void attack(Character Target)
        {
            Target.hp -= Damage;
        }

        public bool isDead()
        {
            if (hp >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character Target)
        {
            if (DistanceTo(Target) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character Target)
        {
            int xTemp, yTemp, sum;

            xTemp = Target.X_Pos - X_Pos;
            yTemp = Target.Y_Pos - Y_Pos;

            if (xTemp < 0)
            {
                xTemp = xTemp * -1;
            }
            else if (yTemp > 0)
            {
                yTemp = yTemp * -1;
            }

            sum = xTemp + yTemp;
            return sum;
 
        }

        public void Move(Movement move, Character TargetC)
        {
            switch (move)
            {
                case Movement.Idle:
                    TargetC.X_Pos = X_Pos;
                    TargetC.Y_Pos = Y_Pos;
                    break;
                case Movement.Up:
                    TargetC.Y_Pos--;
                    break;
                case Movement.Down:
                    TargetC.Y_Pos++;
                    break;
                case Movement.Left:
                    TargetC.X_Pos--;
                    break;
                case Movement.Right:
                    TargetC.X_Pos++;
                    break;
         
            }
        }

        /*    public abstract Movement ReturnMove(Movement move = 0)
            {

            }*/

        public override abstract string ToString();
        
    }
}
