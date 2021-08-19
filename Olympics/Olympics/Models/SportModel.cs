using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Models
{
    public class SportModel
    {
        public int Id { get; set; }
        public string SportName { get; set; }
        public bool TeamActivity { get; set; }
        public List<string> TeamActivityProperties { get; set; } = new List<string>() { "Team", "Non-team" };
    }
}
