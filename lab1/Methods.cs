﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal static class Methods
    {
        // 1. Get all apartments with floor greater than or equal to 5 and sort them by area in ascending order
        public static void GetApartmentsByFloorAreaAsc(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        where apartment.Floor >= 5
                        orderby apartment.Area ascending
                        select apartment;
            
            Console.WriteLine("\nGet all apartments with floor greater than or equal to 5 and sort them by area in ascending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 2. Get all apartments with area greater than 70 and sort them by floor in descending order
        public static void GetApartmentsByAreaFloorDesc(List<Apartments> apartments)
        {
            var query = apartments
                .Where(apartment => apartment.Area > 70)
                .OrderByDescending(apartment => apartment.Floor);

            Console.WriteLine("\nGet all apartments with area greater than 70 and sort them by floor in descending order");
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 3. Group apartments by floor and count the number of apartments on each floor
        public static void GroupApartmentsByFloorCount(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        group apartment by apartment.Floor into floorGroup
                        select new { Floor = floorGroup.Key, Count = floorGroup.Count() };

            Console.WriteLine("\nGroup apartments by floor and count the number of apartments on each floor");
            foreach (var item in query)
            {
                Console.WriteLine($"Floor: {item.Floor}, Count: {item.Count}");
            }
        }

        // 4. Group apartments by floor and calculate the average area of each floor
        public static void GroupApartmentsByFloorAvgArea(List<Apartments> apartments)
        {
            var query = apartments
                .GroupBy(apartment => apartment.Floor)
                .Select(floorGroup => new { Floor = floorGroup.Key, AverageArea = floorGroup.Average(apartment => apartment.Area) });

            Console.WriteLine("\nGroup apartments by floor and calculate the average area of each floor");
            foreach (var item in query)
            {
                Console.WriteLine($"Floor: {item.Floor}, Average area: {item.AverageArea}");
            }
        }

        // 5. Get all real estate agencies that have at least one apartment for sale and sort them by name in ascending order
        public static void GetAgenciesWithApartments(List<RealEstateAgencies> realEstateAgencies, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = (from realEstateAgency in realEstateAgencies
                        join apartmentAgency in apartmentAgencies on realEstateAgency.RealEstateAgenciesID equals apartmentAgency.RealEstateAgenciesID
                        orderby realEstateAgency.Name ascending
                        select realEstateAgency).Distinct();

            Console.WriteLine("\nGet all real estate agencies that have at least one apartment for sale and sort them by name in ascending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 6. Get all realtors whose phone number starts with "+1 123" and sort them by name in descending order
        public static void GetRealtorsByPhoneNumber(List<Realtors> realtors)
        {
            var query = realtors
                .Where(realtor => realtor.PhoneNumber.StartsWith("+1 123"))
                .OrderByDescending(realtor => realtor.Name);

            Console.WriteLine("\nGet all realtors whose phone number starts with \"+1 123\" and sort them by name in descending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 7. Get all apartments with an area greater than 70 and a floor greater than or equal to 5
        public static void GetApartmentsByAreaFloor(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        where apartment.Area > 70 && apartment.Floor >= 5
                        select apartment;

            Console.WriteLine("\nGet all apartments with an area greater than 70 and a floor greater than or equal to 5");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 8. Get all apartments that are not on the first floor and sort them by area in descending order
        public static void GetApartmentsByFloorAreaDesc(List<Apartments> apartments)
        {
            var query = apartments
                .Where(apartment => apartment.Floor != 1)
                .OrderByDescending(apartment => apartment.Area);

            Console.WriteLine("\nGet all apartments that are not on the first floor and sort them by area in descending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 9. Group apartments by floor and calculate the average area of each floor, where the floor is greater than or equal to 4
        public static void GroupApartmentsByFloorGr4AvgArea(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        where apartment.Floor >= 4
                        group apartment by apartment.Floor into floorGroup
                        select new { Floor = floorGroup.Key, AverageArea = floorGroup.Average(apartment => apartment.Area) };

            Console.WriteLine("\nGroup apartments by floor and calculate the average area of each floor, where the floor is greater than or equal to 4");
            foreach (var item in query)
            {
                Console.WriteLine($"Floor: {item.Floor}, Average area: {item.AverageArea}");
            }
        }

        // 10. Get all real estate agencies that have apartments for sale with a price greater than or equal to 300000 and sort them by name in descending order
        public static void GetAgenciesApartmentsByPrice(List<RealEstateAgencies> realEstateAgencies, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = (from realEstateAgency in realEstateAgencies
                        join apartmentAgency in apartmentAgencies on realEstateAgency.RealEstateAgenciesID equals apartmentAgency.RealEstateAgenciesID
                        where apartmentAgency.ApartmentsPrice >= 300000
                        orderby realEstateAgency.Name descending
                        select realEstateAgency).Distinct();

            Console.WriteLine("\nGet all real estate agencies that have apartments for sale with a price greater than or equal to 300000 and sort them by name in descending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 11. Get all realtors whose name starts with "A" or "B" and sort them by name in ascending order
        public static void GetRealtorsByNameAOrB(List<Realtors> realtors)
        {
            var query = realtors
                .Where(realtor => realtor.Name.StartsWith("A") || realtor.Name.StartsWith("B"))
                .OrderBy(realtor => realtor.Name);

            Console.WriteLine("\nGet all realtors whose name starts with \"A\" or \"B\" and sort them by name in ascending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 12. Get all apartments that have a price between 150000 and 300000, sorted by price in descending order
        public static void GetApartmentsByPrice(List<Apartments> apartments, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = from apartment in apartments
                        join apartmentAgency in apartmentAgencies on apartment.ApartmentsID equals apartmentAgency.ApartmentsID
                        where apartmentAgency.ApartmentsPrice >= 150000 && apartmentAgency.ApartmentsPrice <= 300000
                        orderby apartmentAgency.ApartmentsPrice descending
                        select apartment;

            Console.WriteLine("\nGet all apartments that have a price between 50000 and 100000, sorted by price in descending order");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 13. Get all real estate agencies and the number of apartments they have for sale
        public static void GetAgenciesWithApartmentCount(List<RealEstateAgencies> realEstateAgencies, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = from realEstateAgency in realEstateAgencies
                        join apartmentAgency in apartmentAgencies on realEstateAgency.RealEstateAgenciesID equals apartmentAgency.RealEstateAgenciesID into agencyApartments
                        select new { realEstateAgency.Name, Count = agencyApartments.Count() };

            Console.WriteLine("\nGet all real estate agencies and the number of apartments they have for sale");
            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.Name}, Count: {item.Count}");
            }
        }

        // 14. Group apartments by floor and calculate the sum of their areas for each floor, where the floor is less than or equal to 3
        public static void GroupApartmentsByFloorSumAreaFloorLess3(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        where apartment.Floor <= 3
                        group apartment by apartment.Floor into floorGroup
                        select new { Floor = floorGroup.Key, SumArea = floorGroup.Sum(apartment => apartment.Area) };

            Console.WriteLine("\nGroup apartments by floor and calculate the sum of their areas for each floor, where the floor is less than or equal to 3");
            foreach (var item in query)
            {
                Console.WriteLine($"Floor: {item.Floor}, Sum area: {item.SumArea}");
            }
        }

        //15. Get all apartments with an area greater than or equal to 80 and a price greater than or equal to 250000, sorted by price in ascending
        public static void GetApartmentsByAreaPrice(List<Apartments> apartments, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = from apartment in apartments
                        join apartmentAgency in apartmentAgencies on apartment.ApartmentsID equals apartmentAgency.ApartmentsID
                        where apartment.Area >= 80 && apartmentAgency.ApartmentsPrice >= 250000
                        orderby apartmentAgency.ApartmentsPrice ascending
                        select apartment;

            Console.WriteLine("\nGet all apartments with an area greater than or equal to 80 and a price greater than or equal to 250000, sorted by price in ascending");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 16. Get all real estate agencies and their addresses, sorted by name in ascending order
        public static void GetAgenciesWithNameAddress(List<RealEstateAgencies> realEstateAgencies)
        {
            var query = realEstateAgencies.OrderBy(realEstateAgency => realEstateAgency.Name)
                                          .Select(realEstateAgency => new { realEstateAgency.Name, realEstateAgency.Addresses });

            Console.WriteLine("\nGet all real estate agencies and their addresses, sorted by name in ascending order");
            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.Name}, Address: {item.Addresses}");
            }
        }

        // 17. Get all realtors and their phone numbers, sorted by phone number in ascending order
        public static void GetRealtorsWithNamePhoneNumber(List<Realtors> realtors)
        {
            var query = realtors.OrderBy(realtor => realtor.PhoneNumber)
                                .Select(realtor => new { realtor.Name, realtor.PhoneNumber });

            Console.WriteLine("\nGet all realtors and their phone numbers, sorted by phone number in ascending order");
            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.Name}, Phone number: {item.PhoneNumber}");
            }
        }

        // 18. Get all apartments that are not sold by any real estate agency
        public static void GetUnsoldApartments(List<Apartments> apartments, List<Apartments_RealEstateAgencies> apartmentAgencies)
        {
            var query = from apartment in apartments
                        where !(from apartmentAgency in apartmentAgencies select apartmentAgency.ApartmentsID).Contains(apartment.ApartmentsID)
                        select apartment;

            Console.WriteLine("\nGet all apartments that are not sold by any real estate agency");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 19. Get all apartments
        public static void GetAllApartments(List<Apartments> apartments)
        {
            var query = from apartment in apartments
                        select apartment;

            Console.WriteLine("\nGet all apartments");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 20. Get all real estate agencies
        public static void GetAllRealEstateAgencies(List<RealEstateAgencies> realEstateAgencies)
        {
            var query = from realEstateAgency in realEstateAgencies
                        select realEstateAgency;

            Console.WriteLine("\nGet all real estate agencies");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        // 21. Get all realtors
        public static void GetAllRealtors(List<Realtors> realtors)
        {
            var query = from realtor in realtors
                        select realtor;

            Console.WriteLine("\nGet all realtors");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
