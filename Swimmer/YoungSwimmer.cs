using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmer
{
    //adds the Youngswimmer class
    class YoungSwimmer:Swimmer
    {
        private Boolean tired = false;
        
        public YoungSwimmer(string name) : base(name)
        {

        }
        public YoungSwimmer(string name, BathingSuit suit) : base(name, suit)
        {

        }
        public override void SetSuit(BathingSuit bathingSuit)
        {   
           base.SetSuit(bathingSuit);   
        }
        //makes youngswimmer swim and makes them tired and if swimming twice then they say that they are tired
       public override void Swim()
        {
            if (tired == false)
            {
                tired = true;
                base.Swim();
            }
            else if (tired == true)
            {
                Console.WriteLine("I'm so tired - time to get out");
            }

        }
    }
}
