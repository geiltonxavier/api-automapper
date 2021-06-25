namespace API_AutoMapperExample.Models
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
