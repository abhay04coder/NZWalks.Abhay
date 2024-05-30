namespace NZWalks.API.Models.Domain
{
    public class Walks
    {


        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public Guid RegionId { get; set; }

        public Guid DifficultyId { get; set; }  

        //Navigation Property

        public Region Region { get; set; }

        public WalkDifficulty Difficulty { get; set; }
    }
}
