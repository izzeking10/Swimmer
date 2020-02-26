using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmer
{
    class Program
    {
        static void Main(string[] args)
        {
            SwimmerTest(args);
            Console.ReadKey();
        }
        // tests the program if its working
        public static void  SwimmerTest(String[] args)
        {
            //creates two Swimmers that are named Johan and Magnus
            Swimmer johan = new Swimmer("Johan");
            Swimmer magnus = new Swimmer("Magnus", new BathingSuit());
            //adds a Bathingsuit to Johan
            johan.SetSuit(new BathingSuit());
            //Adds no bathingsuit to Magnus
            magnus.SetSuit(null);
            //Creates a professionalSwimmer called Eric
            ProfessionalSwimmer eric = new ProfessionalSwimmer("Eric", new BathingSuit());
            //tries to set professionalSwimmer's bathingsuit to none/null
            eric.SetSuit(null);
            List<Swimmer> swimmers = new List<Swimmer>();
            swimmers.Add(johan);
            //Creates a youngswimmer named Christoffer
            swimmers.Add(new YoungSwimmer("Christoffer", new BathingSuit()));
            //making all swimmers swim
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }

            //making all swimmers swim
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }
        }


    }

}
