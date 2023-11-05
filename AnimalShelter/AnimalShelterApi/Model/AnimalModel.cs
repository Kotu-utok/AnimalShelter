namespace AnimalShelterApi.Model
{
    public class AnimalModel
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public DateTime DateOfArrival { get; set; }
        public Decimal WeightAtArrival { get; set; }

    }
}
