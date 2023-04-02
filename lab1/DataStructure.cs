using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Apartments
    {
        public int ApartmentsID { get; set; }
        public string Addresses { get; set; }
        public int Floor { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return $"Address: {Addresses}, Floor: {Floor}, Area: {Area}";
        }
    }

    internal class RealEstateAgencies
    {
        public int RealEstateAgenciesID { get; set; }
        public string Name { get; set; }
        public string Addresses { get; set; }
        public int RealtorsID { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Addresses}, RealtorsID: {RealtorsID}";
        }
    }

    internal class Realtors
    {
        public int RealtorsID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
        }
    }

    internal class Apartments_RealEstateAgencies
    {
        public int Apartments_RealEstateAgenciesID { get; set; }
        public int ApartmentsID { get; set; }
        public int RealEstateAgenciesID { get; set; }
        public double ApartmentsPrice { get; set; }

        public override string ToString()
        {
            return $"ApartmentsID: {ApartmentsID}, RealEstateAgenciesID: {RealEstateAgenciesID}, ApartmentsPrice: {ApartmentsPrice}";
        }
    }
}
