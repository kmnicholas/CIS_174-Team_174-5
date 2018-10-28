using System;

namespace FootballApplication.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamHome { get; set; }
        public string TeamName { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
		// comment
    }
}