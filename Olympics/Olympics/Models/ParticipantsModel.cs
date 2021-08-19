using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Models
{

    public class ParticipantsModel
    {
        public AthleteModel Athlete { get; set; }
        public List<AthleteModel> Athletes { get; set; } = new List<AthleteModel>();
        public List<CountryModel> Countries { get; set; } = new List<CountryModel>();
        public List<SportModel> Sports { get; set; } = new List<SportModel>();  
    }

}
