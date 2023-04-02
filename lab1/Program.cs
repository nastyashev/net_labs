using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Apartments> apartments = new List<Apartments>
            {
                new Apartments { ApartmentsID = 1, Addresses = "123 Main St", Floor = 2, Area = 75.5 },
                new Apartments { ApartmentsID = 2, Addresses = "456 Elm St", Floor = 1, Area = 90.0 },
                new Apartments { ApartmentsID = 3, Addresses = "789 Oak St", Floor = 3, Area = 100.0 },
                new Apartments { ApartmentsID = 4, Addresses = "1011 Maple St", Floor = 2, Area = 80.0 },
                new Apartments { ApartmentsID = 5, Addresses = "1213 Pine St", Floor = 1, Area = 85.5 },
                new Apartments { ApartmentsID = 6, Addresses = "1415 Cedar St", Floor = 3, Area = 95.0 },
                new Apartments { ApartmentsID = 7, Addresses = "1617 Birch St", Floor = 4, Area = 120.0 },
                new Apartments { ApartmentsID = 8, Addresses = "1819 Walnut St", Floor = 5, Area = 110.0 },
                new Apartments { ApartmentsID = 9, Addresses = "2021 Spruce St", Floor = 6, Area = 105.5 },
                new Apartments { ApartmentsID = 10, Addresses = "2223 Ash St", Floor = 2, Area = 70.0 },
                new Apartments { ApartmentsID = 11, Addresses = "2425 Cedar St", Floor = 1, Area = 65.0 },
                new Apartments { ApartmentsID = 12, Addresses = "2627 Maple St", Floor = 3, Area = 80.5 },
                new Apartments { ApartmentsID = 13, Addresses = "2829 Pine St", Floor = 4, Area = 90.0 },
                new Apartments { ApartmentsID = 14, Addresses = "3031 Oak St", Floor = 2, Area = 100.0 },
                new Apartments { ApartmentsID = 15, Addresses = "3233 Walnut St", Floor = 1, Area = 75.0 }
            };

            var realEstateAgencies = new List<RealEstateAgencies>
            {
                new RealEstateAgencies { RealEstateAgenciesID = 1, Name = "New York Realty", Addresses = "5th Avenue, New York", RealtorsID = 1 },
                new RealEstateAgencies { RealEstateAgenciesID = 2, Name = "LA Homes", Addresses = "Hollywood Boulevard, Los Angeles", RealtorsID = 2 },
                new RealEstateAgencies { RealEstateAgenciesID = 3, Name = "SF Properties", Addresses = "Lombard Street, San Francisco", RealtorsID = 3 },
                new RealEstateAgencies { RealEstateAgenciesID = 4, Name = "Skyline Realty", Addresses = "Broadway, New York", RealtorsID = 4 },
                new RealEstateAgencies { RealEstateAgenciesID = 5, Name = "Sunrise Properties", Addresses = "Sunset Boulevard, Los Angeles", RealtorsID = 1 },
                new RealEstateAgencies { RealEstateAgenciesID = 6, Name = "Golden Gate Realty", Addresses = "Golden Gate Bridge, San Francisco", RealtorsID = 6 },
                new RealEstateAgencies { RealEstateAgenciesID = 7, Name = "Miami Dream Homes", Addresses = "Ocean Drive, Miami", RealtorsID = 7 },
                new RealEstateAgencies { RealEstateAgenciesID = 8, Name = "Toronto Realty", Addresses = "King Street, Toronto", RealtorsID = 8 },
                new RealEstateAgencies { RealEstateAgenciesID = 9, Name = "Vancouver Properties", Addresses = "Granville Street, Vancouver", RealtorsID = 9 },
                new RealEstateAgencies { RealEstateAgenciesID = 10, Name = "London Homes", Addresses = "Baker Street, London", RealtorsID = 10 },
                new RealEstateAgencies { RealEstateAgenciesID = 11, Name = "Paris Realty", Addresses = "Champs-Elysees, Paris", RealtorsID = 10 },
                new RealEstateAgencies { RealEstateAgenciesID = 12, Name = "Tokyo Properties", Addresses = "Shibuya Crossing, Tokyo", RealtorsID = 12 },
                new RealEstateAgencies { RealEstateAgenciesID = 13, Name = "Sydney Homes", Addresses = "Bondi Beach, Sydney", RealtorsID = 13 },
                new RealEstateAgencies { RealEstateAgenciesID = 14, Name = "Dubai Properties", Addresses = "Burj Khalifa, Dubai", RealtorsID = 14 },
                new RealEstateAgencies { RealEstateAgenciesID = 15, Name = "Kyiv Realty", Addresses = "Red Square, Moscow", RealtorsID = 15 }
            };


            List<Realtors> realtors = new List<Realtors>
            {
                new Realtors { RealtorsID = 1, Name = "John Doe", PhoneNumber = "+1 123-456-7890" },
                new Realtors { RealtorsID = 2, Name = "Jane Smith", PhoneNumber = "+1 234-567-8901" },
                new Realtors { RealtorsID = 3, Name = "Bob Johnson", PhoneNumber = "+1 345-678-9012" },
                new Realtors { RealtorsID = 4, Name = "Alice Davis", PhoneNumber = "+1 456-789-0123" },
                new Realtors { RealtorsID = 5, Name = "Mike Wilson", PhoneNumber = "+1 567-890-1234" },
                new Realtors { RealtorsID = 6, Name = "Emily Lee", PhoneNumber = "+1 678-901-2345" },
                new Realtors { RealtorsID = 7, Name = "David Brown", PhoneNumber = "+1 789-012-3456" },
                new Realtors { RealtorsID = 8, Name = "Samantha Chen", PhoneNumber = "+1 890-123-4567" },
                new Realtors { RealtorsID = 9, Name = "Richard Taylor", PhoneNumber = "+1 901-234-5678" },
                new Realtors { RealtorsID = 10, Name = "Karen Martin", PhoneNumber = "+1 012-345-6789" },
                new Realtors { RealtorsID = 11, Name = "Tom White", PhoneNumber = "+1 123-456-7890" },
                new Realtors { RealtorsID = 12, Name = "Amy Kim", PhoneNumber = "+1 234-567-8901" },
                new Realtors { RealtorsID = 13, Name = "Steve Chen", PhoneNumber = "+1 345-678-9012" },
                new Realtors { RealtorsID = 14, Name = "Grace Lee", PhoneNumber = "+1 456-789-0123" },
                new Realtors { RealtorsID = 15, Name = "Henry Smith", PhoneNumber = "+1 567-890-1234" },
            };

            List<Apartments_RealEstateAgencies> apartmentsRealEstateAgencies = new List<Apartments_RealEstateAgencies>
            {
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 1, ApartmentsID = 1, RealEstateAgenciesID = 1, ApartmentsPrice = 200000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 2, ApartmentsID = 2, RealEstateAgenciesID = 2, ApartmentsPrice = 300000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 3, ApartmentsID = 2, RealEstateAgenciesID = 3, ApartmentsPrice = 250000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 4, ApartmentsID = 4, RealEstateAgenciesID = 4, ApartmentsPrice = 400000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 5, ApartmentsID = 5, RealEstateAgenciesID = 5, ApartmentsPrice = 150000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 6, ApartmentsID = 6, RealEstateAgenciesID = 6, ApartmentsPrice = 500000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 7, ApartmentsID = 7, RealEstateAgenciesID = 7, ApartmentsPrice = 350000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 8, ApartmentsID = 8, RealEstateAgenciesID = 8, ApartmentsPrice = 450000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 9, ApartmentsID = 1, RealEstateAgenciesID = 9, ApartmentsPrice = 275000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 10, ApartmentsID = 10, RealEstateAgenciesID = 10, ApartmentsPrice = 225000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 11, ApartmentsID = 11, RealEstateAgenciesID = 1, ApartmentsPrice = 300000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 12, ApartmentsID = 12, RealEstateAgenciesID = 2, ApartmentsPrice = 375000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 13, ApartmentsID = 13, RealEstateAgenciesID = 3, ApartmentsPrice = 425000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 14, ApartmentsID = 14, RealEstateAgenciesID = 4, ApartmentsPrice = 475000 },
                new Apartments_RealEstateAgencies { Apartments_RealEstateAgenciesID = 15, ApartmentsID = 15, RealEstateAgenciesID = 5, ApartmentsPrice = 250000 },
            };


            Methods.GetApartmentsByFloorAreaAsc(apartments);
            Methods.GetApartmentsByAreaFloorDesc(apartments);
            Methods.GroupApartmentsByFloorCount(apartments);
            Methods.GroupApartmentsByFloorAvgArea(apartments);
            Methods.GetAgenciesWithApartments(realEstateAgencies, apartmentsRealEstateAgencies);
            Methods.GetRealtorsByPhoneNumber(realtors);
            Methods.GetApartmentsByAreaFloor(apartments);
            Methods.GetApartmentsByFloorAreaDesc(apartments);
            Methods.GroupApartmentsByFloorGr4AvgArea(apartments);
            Methods.GetAgenciesApartmentsByPrice(realEstateAgencies, apartmentsRealEstateAgencies);
            Methods.GetRealtorsByNameAOrB(realtors);
            Methods.GetApartmentsByPrice(apartments, apartmentsRealEstateAgencies);
            Methods.GetAgenciesWithApartmentCount(realEstateAgencies, apartmentsRealEstateAgencies);
            Methods.GroupApartmentsByFloorSumAreaFloorLess3(apartments);
            Methods.GetApartmentsByAreaPrice(apartments, apartmentsRealEstateAgencies);
            Methods.GetAgenciesWithNameAddress(realEstateAgencies);
            Methods.GetRealtorsWithNamePhoneNumber(realtors);
            Methods.GetUnsoldApartments(apartments, apartmentsRealEstateAgencies);
            Methods.GetAllApartments(apartments);
            Methods.GetAllRealEstateAgencies(realEstateAgencies);
            Methods.GetAllRealEstateAgencies(realEstateAgencies);
            Methods.GetAllRealtors(realtors);
        }
    }
}
