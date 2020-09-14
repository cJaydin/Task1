namespace Task1
{
    abstract class Tile
    {
        // protected variables
        private int x_Pos;
        private int y_Pos;

        public int X_Pos { get => x_Pos; set => x_Pos = value; }
        public int Y_Pos { get => y_Pos; set => y_Pos = value; }

        public enum TileType { Hero, Enemy, Gold, Weapon };

        public Tile(int x, int y)
        {
            this.x_Pos = x;
            this.y_Pos = y;
        }
    }

}
