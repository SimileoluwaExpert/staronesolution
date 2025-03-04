namespace starone.Models.Domain
{
    public class PassagerDetails
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }

        public int Age { get; set; }
        public int NumberOfSiblingsSpouse { get; set; }

        public int NumberOfParentsChildren { get; set; }

        public int PassagerClass { get; set; }

        public float Fare { get; set; }

        public Guid GenderId { get; set; }

        public Guid SurvivalStatusId { get; set; }

        public Guid PassagerClassId { get; set; }

        // Navigation properties

        public PassagerGender passagerGender { get; set; }

        public SurvivalStatus survivalStatus { get; set; }

        public PassagerClass passagerClass { get; set; }
    }
}
