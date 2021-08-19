using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Models
{

    public class ParticipantsModel
    {
        public ParticipantsModel()
        {
            OrderByList = new List<string>()
            {
                "Name", "Surname", "Country"
            };
        }

        public AthleteModel Athlete { get; set; }
        public List<AthleteModel> AllAthletes { get; set; }
        public CountryModel Country { get; set; }
        public List<CountryModel> AllCountries { get; set; }
        public SportModel Sport { get; set; }
        public List<SportModel> AllSports { get; set; }
        public string OrderBy { get; set; }
        public List<string> OrderByList { get; set; }

    }

}
