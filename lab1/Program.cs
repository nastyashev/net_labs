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
            List<Apartments> apartments = Enumerable.Range(1, 15)
                .Select(i => new Apartments
                {
                    ApartmentsID = i,
                    Addresses = $"Address {i}",
                    Floor = i % 10 + 1,
                    Area = 50 + i * 2.5
                })
                .ToList();

            List<RealEstateAgencies> realEstateAgencies = Enumerable.Range(1, 15)
                .Select(i => new RealEstateAgencies
                {
                    RealEstateAgenciesID = i,
                    Name = $"Agency {i}",
                    Addresses = $"Address {i}",
                    RealtorsID = i % 5 + 1
                })
                .ToList();

            List<Realtors> realtors = Enumerable.Range(1, 15)
                .Select(i => new Realtors
                {
                    RealtorsID = i,
                    Name = $"Realtor {i}",
                    PhoneNumber = $"555-555-{i.ToString().PadLeft(4, '0')}"
                })
                .ToList();

            List<Apartments_RealEstateAgencies> apartmentAgencies = Enumerable.Range(1, 15)
                .Select(i => new Apartments_RealEstateAgencies
                {
                    Apartments_RealEstateAgenciesID = i,
                    ApartmentsID = i % 5 + 1,
                    RealEstateAgenciesID = i % 3 + 1,
                    ApartmentsPrice = 50000 + i * 1000
                })
                .ToList();

            Methods.GetApartmentsByFloorAndAreaAscending(apartments);
            Methods.GetApartmentsByAreaAndFloorDescending(apartments);
            Methods.GroupApartmentsByFloorAndCount(apartments);
            Methods.GroupApartmentsByFloorAndAverageArea(apartments);
            Methods.GetAgenciesWithApartments(realEstateAgencies, apartmentAgencies);
            Methods.GetRealtorsByPhoneNumber(realtors);
            Methods.GetApartmentsByAreaAndFloor(apartments);
            Methods.GetApartmentsByFloorAndAreaDescending(apartments);
            Methods.GroupApartmentsByFloorAndAverageAreaWhereFloorGreaterOrEqualTo5(apartments);
            Methods.GetAgenciesWithApartmentsByPrice(realEstateAgencies, apartmentAgencies);
            Methods.GetRealtorsByNameStartingWithAOrB(realtors);
            Methods.GetApartmentsByPrice(apartments, apartmentAgencies);
            Methods.GetAgenciesWithApartmentCount(realEstateAgencies, apartmentAgencies);
            Methods.GroupApartmentsByFloorAndSumAreaWhereFloorLessOrEqualTo3(apartments);
            Methods.GetApartmentsByAreaAndPrice(apartments, apartmentAgencies);
            Methods.GetAgenciesWithNameAndAddress(realEstateAgencies);
            Methods.GetRealtorsWithNameAndPhoneNumber(realtors);
            Methods.GetUnsoldApartments(apartments, apartmentAgencies);
            Methods.GetAllApartments(apartments);
            Methods.GetAllRealEstateAgencies(realEstateAgencies);
            Methods.GetAllRealEstateAgencies(realEstateAgencies);
            Methods.GetAllRealtors(realtors);
        }
    }
}
