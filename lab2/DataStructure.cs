using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab2
{
    public class Apartment
    {
        public int ApartmentsID { get; set; }
        public string Addresses { get; set; }
        public int Floor { get; set; }
        public double Area { get; set; }

        public Apartment(int apartmentsID, string addresses, int floor, double area)
        {
            ApartmentsID = apartmentsID;
            Addresses = addresses;
            Floor = floor;
            Area = area;
        }

        public Apartment() { }

        public override string ToString()
        {
            return $"Address: {Addresses}, Floor: {Floor}, Area: {Area}";
        }
    }

    public class RealEstateAgencies
    {
        public int RealEstateAgenciesID { get; set; }
        public string Name { get; set; }
        public string Addresses { get; set; }
        public int RealtorsID { get; set; }

        public RealEstateAgencies(int realEstateAgenciesID, string name, string addresses, int realtorsID)
        {
            RealEstateAgenciesID = realEstateAgenciesID;
            Name = name;
            Addresses = addresses;
            RealtorsID = realtorsID;
        }

        public RealEstateAgencies() { }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Addresses}, RealtorsID: {RealtorsID}";
        }
    }

    public class Realtor
    {
        public int RealtorsID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Realtor (int realtorsID, string name, string phoneNumber)
        {
            RealtorsID = realtorsID;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public Realtor() { }

        public override string ToString()
        {
            return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
        }
    }

    public class Apartments_RealEstateAgencies
    {
        public int Apartments_RealEstateAgenciesID { get; set; }
        public int ApartmentsID { get; set; }
        public int RealEstateAgenciesID { get; set; }
        public double ApartmentsPrice { get; set; }

        public Apartments_RealEstateAgencies (int apartments_RealEstateAgenciesID, int apartmentsID, int realEstateAgenciesID, double apartmentsPrice)
        {
            Apartments_RealEstateAgenciesID = apartments_RealEstateAgenciesID;
            ApartmentsID = apartmentsID;
            RealEstateAgenciesID = realEstateAgenciesID;
            ApartmentsPrice = apartmentsPrice;
        }

        public Apartments_RealEstateAgencies() { }

        public override string ToString()
        {
            return $"ApartmentsID: {ApartmentsID}, RealEstateAgenciesID: {RealEstateAgenciesID}, ApartmentsPrice: {ApartmentsPrice}";
        }
    }

    public class Data
    {
        public List<Apartment> Apartments { get; set; }
        public List<RealEstateAgencies> RealEstateAgencies { get; set; }
        public List<Realtor> Realtors { get; set; }
        public List<Apartments_RealEstateAgencies> Apartments_RealEstateAgencies { get; set;  }
        public Data () { }
    }
}
