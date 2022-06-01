

namespace DoctorWhhoo.Db
{
    public class Companion
    {
        public Companion()
        {
            EpComp = new List<EpisodeCompanion>();
        }

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public bool WhoPlayed { get; set; }
        public List<EpisodeCompanion> EpComp { get; set; }
    }
}
