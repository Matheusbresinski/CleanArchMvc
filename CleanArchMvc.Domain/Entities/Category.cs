namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
 
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }
        public Category(int id, string name)
        {
            DomainExceptionValidation.When( id < 0, "Invalid Id value");
            Id = id;
            Name = name;
        }
        public Icolletions<Product> Product { get; set; }          
    
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string IsNullOrEmpty(name), 
            "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3 , 
            "Invalid name. too short, minimum 3 charecters");

            Name = name;
        }
    }
}