using System;
namespace ProseFighter
{
    public class Fighter
    {
        public string Name
        { get; set; }

        //hit points
        public int HitPoints
        { get; set; }

        //moves
        //int highKick = 2;
        //int punch = 1;
        //int lowKick = 0;
        public int Move;

        public Fighter(string name, int hitPoints, int move)
        {
            Name = name;
            HitPoints = hitPoints;
            Move = move;
        }
    }
}
