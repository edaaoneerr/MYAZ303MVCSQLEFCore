namespace MVCSQLEFCore.Entities
{
    public class Specialty
    {
        public int DoctorId { get; set; }
        public string? SpecialtyName { get; set; }
        public string? NumberOfPatients { get; set; }

        public Doctor? Doctor { get; set; }
    }
}
