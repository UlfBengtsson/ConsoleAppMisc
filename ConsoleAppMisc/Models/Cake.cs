using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMisc.Models
{
    public class Cake
    {
        string filling;
        string topping;
        bool bakedAndDone;
        TimeSpan bakeTime;
        double tempReq;

        public bool BakedAndDone { get { return bakedAndDone; } }

        public Cake(string filling, string topping, TimeSpan bakeTime, double tempReq)
        {
            this.bakeTime = bakeTime;
            this.tempReq = tempReq;
            this.filling = filling;
            this.topping = topping;
        }

        public bool BakeTheCake(double tempeture, TimeSpan bakeTime)
        {
            if (tempeture > (tempReq*2) && this.bakeTime < (bakeTime*2))
            {
                throw new Exception("Time and tempeture were too high so you have burnt your cake!");
            }

            if (tempeture >= tempReq && this.bakeTime <= bakeTime)
            {
                bakedAndDone = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
