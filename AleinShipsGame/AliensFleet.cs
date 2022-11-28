using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleinShipsGame
{
    public  class AliensFleet
    {
        public List<Ship> TheFleet = new List<Ship>();
        
        
        public void CreateNewShip()
        {
            this.TheFleet.Add(new Ship());
       }
        public void MoveAllFleetInLeft()
        {
            for (int i = 0; i < this.TheFleet.Count; i++)
            {
                this.TheFleet[i + 1].x+=20;
               

            }
        }
        public void MoveAllFleetInRight()
        {
            for (int i = 0; i < this.TheFleet.Count; i++)
            {
                this.TheFleet[i + 1].x -= 20;


            }
        }
        public void MoveAllFleetDown()
        {
            for (int i = 0; i < this.TheFleet.Count; i++)
            {
                this.TheFleet[i + 1].y += 20;


            }
        }
    }
}
