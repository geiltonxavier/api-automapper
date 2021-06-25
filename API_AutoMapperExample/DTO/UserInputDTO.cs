namespace API_AutoMapperExample.DTO
{
    public class UserInputDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public AddressInputDTO Address { get; set; }
    }
}
