namespace MVCSQLEFCore.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string? PatientFirstName { get; set; }
        public string? PatientLastName { get; set; }
        public string PatientFullName => String.Concat(PatientFirstName, " ", PatientLastName);
     
        public Doctor? Doctor { get; set; }
        public string? FirstName { get; set; }

    }
}
