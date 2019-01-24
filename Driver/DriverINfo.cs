using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class Driver
    {

        public int CarID { get; set; }
        public int OverSpeed { get; set; }
        public int Swerve { get; set; }
        public int MissedStop { get; set; }
        public int Following { get; set; }

        public Driver(int carID, int overSpeed, int swerve, int missedStop, int following)
        {
            CarID = carID;
            OverSpeed = overSpeed;
            Swerve = swerve;
            MissedStop = missedStop;
            Following = following;
        }
        public Driver()
        {
                
        }
    }
}
