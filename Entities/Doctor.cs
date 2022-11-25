namespace MVCSQLEFCore.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string? FirstName { get; set;}
        public string? LastName { get; set; }
        public Specialty? Specialty { get; set; }
        public string? SpecialtyName { get; set; }

        //FK
        public int  InternId { get; set; }
        public Intern? Intern { get; set; }
        public string FullName => String.Concat(FirstName, " ", LastName);

        public Patient? Patient { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}
