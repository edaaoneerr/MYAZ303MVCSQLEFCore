namespace MVCSQLEFCore.Entities
{
    public class Intern
    {
        public int InternId { get;  set; }
        public string? FirstName { get;  set; }
        public string? LastName { get;  set; }


        public string FullName => String.Concat(FirstName," ",LastName);
        public Doctor? Doctor { get; set; }
    }
}
