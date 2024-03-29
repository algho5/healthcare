using Healthcare.Domain.Dtos;
using Healthcare.Domain.Enuns;

namespace Healthcare.Domain
{
    public class Address
    {
        public Address(string street, 
            string city, 
            string zipCode, 
            string district, 
            EUF uF)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
            District = district;
            UF = uF;
        }

        public string Street { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string ZipCode { get; private set; } = string.Empty;
        public string District {get; private set; } = string.Empty;
        public EUF UF { get; private set; }

        private Address () 
        {}

        protected internal static Address From(string street, string city, string zipCode, string district, EUF UF)
        {
            return new Address
            {
                Street = street,
                City = city,
                ZipCode = zipCode,
                District = district, 
                UF = UF
            };
        }
        
        public static implicit operator AddressDto(Address address)
            => new()
            {
                City = address.City,
                District = address.District,
                Street = address.Street,
                UF = address.UF
            };

    }
}