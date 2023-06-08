using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            List<Apartment> apartments = new List<Apartment>
            {
                new Apartment (1, "123 Main St", 2, 75.5),
                new Apartment (2, "456 Elm St", 1, 90.0),
                new Apartment (3, "789 Oak St", 3, 100.0),
                new Apartment (4, "1011 Maple St", 2, 80.0),
                new Apartment (5, "1213 Pine St", 1, 85.5),
                new Apartment (6, "1415 Cedar St", 3, 95.0),
                new Apartment (7, "1617 Birch St", 4, 120.0),
                new Apartment (8, "1819 Walnut St", 5, 110.0),
                new Apartment (9, "2021 Spruce St", 6, 105.5),
                new Apartment (10, "2223 Ash St", 2, 70.0),
                new Apartment (11, "2425 Cedar St", 1, 65.0),
                new Apartment (12, "2627 Maple St", 3, 80.5),
                new Apartment (13, "2829 Pine St", 4, 90.0),
                new Apartment (14, "3031 Oak St", 2, 100.0),
                new Apartment (15, "3233 Walnut St", 1, 75.0)
            };

            List<RealEstateAgencies> realEstateAgencies = new List<RealEstateAgencies>
            {
                new RealEstateAgencies (1, "New York Realty", "5th Avenue, New York", 1),
                new RealEstateAgencies (2, "LA Homes", "Hollywood Boulevard, Los Angeles", 2),
                new RealEstateAgencies (3, "SF Properties", "Lombard Street, San Francisco", 3),
                new RealEstateAgencies (4, "Skyline Realty", "Broadway, New York", 4),
                new RealEstateAgencies (5, "Sunrise Properties", "Sunset Boulevard, Los Angeles", 1),
                new RealEstateAgencies (6, "Golden Gate Realty", "Golden Gate Bridge, San Francisco", 6),
                new RealEstateAgencies (7, "Miami Dream Homes", "Ocean Drive, Miami", 7),
                new RealEstateAgencies (8, "Toronto Realty", "King Street, Toronto", 8),
                new RealEstateAgencies (9, "Vancouver Properties", "Granville Street, Vancouver", 9),
                new RealEstateAgencies (10, "London Homes", "Baker Street, London", 10),
                new RealEstateAgencies (11, "Paris Realty", "Champs-Elysees, Paris", 10),
                new RealEstateAgencies (12, "Tokyo Properties", "Shibuya Crossing, Tokyo", 12),
                new RealEstateAgencies (13, "Sydney Homes", "Bondi Beach, Sydney", 13),
                new RealEstateAgencies (14, "Dubai Properties", "Burj Khalifa, Dubai", 14),
                new RealEstateAgencies (15, "Kyiv Realty", "Khreshchatyk Street, Kyiv", 15)
            };


            List<Realtor> realtors = new List<Realtor>
            {
                new Realtor (1, "John Doe", "+1 123-456-7890"),
                new Realtor (2, "Jane Smith", "+1 234-567-8901"),
                new Realtor (3, "Bob Johnson", "+1 345-678-9012"),
                new Realtor (4, "Alice Davis", "+1 456-789-0123"),
                new Realtor (5, "Mike Wilson", "+1 567-890-1234"),
                new Realtor (6, "Emily Lee", "+1 678-901-2345"),
                new Realtor (7, "David Brown", "+1 789-012-3456"),
                new Realtor (8, "Samantha Chen", "+1 890-123-4567"),
                new Realtor (9, "Richard Taylor", "+1 901-234-5678"),
                new Realtor (10, "Karen Martin", "+1 012-345-6789"),
                new Realtor (11, "Tom White", "+1 123-456-7890"),
                new Realtor (12, "Amy Kim", "+1 234-567-8901"),
                new Realtor (13, "Steve Chen", "+1 345-678-9012"),
                new Realtor (14, "Grace Lee", "+1 456-789-0123"),
                new Realtor (15, "Henry Smith", "+1 567-890-1234"),
            };

            List<Apartments_RealEstateAgencies> apartmentsRealEstateAgencies = new List<Apartments_RealEstateAgencies>
            {
                new Apartments_RealEstateAgencies (1, 1, 1, 200000),
                new Apartments_RealEstateAgencies (2, 2, 2, 300000),
                new Apartments_RealEstateAgencies (3, 2, 3, 250000),
                new Apartments_RealEstateAgencies (4, 4, 4, 400000),
                new Apartments_RealEstateAgencies (5, 5, 5, 150000),
                new Apartments_RealEstateAgencies (6, 6, 6, 500000),
                new Apartments_RealEstateAgencies (7, 7, 7, 350000),
                new Apartments_RealEstateAgencies (8, 8, 8, 450000),
                new Apartments_RealEstateAgencies (9, 1, 9, 275000),
                new Apartments_RealEstateAgencies (10, 10, 10, 225000),
                new Apartments_RealEstateAgencies (11, 11, 1, 300000),
                new Apartments_RealEstateAgencies (12, 12, 2, 375000),
                new Apartments_RealEstateAgencies (13, 13, 3, 425000),
                new Apartments_RealEstateAgencies (14, 14, 4, 475000),
                new Apartments_RealEstateAgencies (15, 15, 5, 250000),
            };

            Data data = new Data ();
            data.Apartments = apartments;
            data.RealEstateAgencies = realEstateAgencies;
            data.Realtors = realtors;
            data.Apartments_RealEstateAgencies = apartmentsRealEstateAgencies;

            string path = "apartments.xml";
            ManageXML.CreateXmlFile(path, data);
            Data readData =  ManageXML.OutputXmlFile(path);

            Print.PrintToConsole(readData);
        }
    }
}
