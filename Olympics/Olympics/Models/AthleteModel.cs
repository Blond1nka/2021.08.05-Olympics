﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Models
{
    public class AthleteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int SportId { get; set; }
        public List<int> Sports { get; set; }
        public List<string> SportsNames { get; set; }

    }
}
