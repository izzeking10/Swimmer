using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmer
{
    class ProfessionalSwimmer:Swimmer
    {
        public ProfessionalSwimmer(string name):base(name)
        {

        }
        public ProfessionalSwimmer(string name, BathingSuit suit):base(name, suit)
        {

        }
        //Makes professionalSwimmer to have a bathingsuit
       public override void SetSuit(BathingSuit bathingSuit)
        {
            if(bathingSuit != null) 
            {
                base.SetSuit(bathingSuit);
            }
        }

    }
}
