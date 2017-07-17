using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    enum Instruments
    {
        Guitar = -50, Vocal = 10, Drums
    }

    struct Musician
    {
        public string Name;
        public Instruments Instrument;
    }

    struct Band
    {
        public string Name;
        public Musician[] Members;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Instruments guitar = Instruments.Guitar;
            Console.WriteLine(Instruments.Guitar);
            Console.WriteLine(guitar.ToString());
            Console.ReadLine();


            string[] instruments = new string[]
            {
                "Guitar", "Vocal", "Drums"
            };

            Musician jagger = new Musician()
            {
                Name = "Mick Jagger",
                Instrument = Instruments.Vocal
            };
            Musician richards = new Musician()
            {
                Name = "Keith Righards",
                Instrument = Instruments.Guitar
            };

            Musician page = new Musician()
            {
                Name = "Jimmy Page",
                Instrument = Instruments.Guitar
            };
            Musician bonnem = new Musician()
            {
                Name = "John Bonnem",
                Instrument = Instruments.Drums
            };

            Musician plant = new Musician()
            {
                Name = "Robert Plant",
                Instrument = Instruments.Vocal
            };

            Band[] goodBands = new Band[2]
            {
                new Band()
                {
                    Name = "Led Zepplin",
                    Members = new Musician[3]
                    {
                        bonnem, page, plant
                    }
                },
                new Band()
                {
                    Name = "The Rolling Stones",
                    Members = new Musician[2]
                    {
                        jagger, richards
                    }
                }
            };

            for (int i = 0; i < goodBands.Length; i++)
            {
                for (int j = 0; j < goodBands[i].Members.Length; j++)
                {
                    if (goodBands[i].Members[j].Instrument == Instruments.Vocal)
                    Console.WriteLine(goodBands[i].Members[j].Name);
                }
            }
        }
    }
}
