using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7.Models
{

    public class ZooResponse
    {
        public bool success { get; set; }
        public int count { get; set; }
        public Annimal[] results { get; set; }
        public Legend legend { get; set; }
    }

    public class Legend
    {
        public string weight { get; set; }
    }

    public class Annimal
    {
        public int id { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
        public Species species { get; set; }
        public string speciesName { get { return species.name; } }
    }

    public class Species
    {
        public string name { get; set; }
        public string _ref { get; set; }
    }


    public class SpecieResponse
    {
        public string name { get; set; }
        public string _ref { get; set; }
        public string diet { get; set; }
        public string habitat { get; set; }
    }

}
