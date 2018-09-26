using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OOPs
{
    class Industries
    {
        private static Dictionary<string, List<string>> _AllIndustries;
        public static Dictionary<string, List<string>> AllIndustries
        {
            get { return _AllIndustries; } 
        }

        static Industries()
        {
            _AllIndustries = new Dictionary<string, List<string>>();
            _AllIndustries.Add("Advertising/Marketing", new List<string>() { "Advertising Agencies", "Advertising/Marketing (General)", "Broadcasting - Radio", "Broadcasting - TV", "CATV Systems", "Communications", "Entertainment", "Event Management", "Marketing Services", "Movie Production/Theaters", "PR" });
            _AllIndustries.Add("Aerospace/Aviation", new List<string>() { "Aerospace/Aviation (General)", "Aerospace/Defense - Major Diversified", "Aerospace/Defense Products & Services", "Air Delivery & Freight Services", "Air Services", "Major Airlines", "Regional Airlines" });
            _AllIndustries.Add("Agriculture", new List<string>() { "Agriculture (General)", "Dairy", "Farming", "Fishery", "Ranching" });
            _AllIndustries.Add("Automotive", new List<string>() { "Auto Dealerships", "Auto Manufacturers", "Auto Parts", "Auto Parts Stores", "Auto Parts Wholesale", "Automotive (General)", "Recreational Vehicles", "Tires", "Trucks/Other Vehicles" });
            _AllIndustries.Add("Biotech and Pharmaceuticals", new List<string>() { "Biotech", "Biotech and Pharmaceuticals (General)", "Clinical Laboratory", "Life Sciences Manufacturing", "Pharmaceuticals" });
            _AllIndustries.Add("Computers and Technology", new List<string>() { "Computer Hardware", "Computer Networking", "Computer Software", "Computer/Network Security", "Computers and Technology (General)", "Information Technology/Services", "Internet", "Nanotechnology", "Semiconductors" });
            _AllIndustries.Add("Construction", new List<string>() { "Architecture/Planning", "Building Materials", "Civil Engineering", "Construction", "Construction (General)", "Glass/Ceramics/Concrete", "Industrial Automation" });
            _AllIndustries.Add("Corporate Services", new List<string>() { "Business Supplies/Equipment", "Corporate Services (General)", "E-Learning", "Human Resources", "Management Consulting", "Market Research", "Outsourcing/Offshoring", "Professional Training", "Program Development", "Staffing/Recruiting", "Translation/Localization" });
            _AllIndustries.Add("Education", new List<string>() { "Education (General)", "Education Management", "E-Learning", "Higher Education", "Primary/Secondary", "Research" });
            _AllIndustries.Add("Finance", new List<string>() { "Accounting", "Banking", "Capital Markets", "Finance (General)", "Financial Services", "Investment Banking/Venture", "Investment Management", "Venture Capital" });
            _AllIndustries.Add("Government", new List<string>() { "Defense/Space", "Executive Office", "Government (General)", "Government Administration", "Government Relations", "International Affairs", "International Trade/Development", "Judiciary", "Law Enforcement", "Legislative Office", "Military", "Political Organization", "Public Policy", "Public Safety", "Research", "Think Tanks" });
            _AllIndustries.Add("Healthcare/Medical", new List<string>() { "Alternative Medicine", "Health/Wellness/Fitness", "Healthcare/Medical (General)", "Hospital/Health Care", "Medical Device", "Medical Practice", "Mental Health Care", "Veterinary" });
            _AllIndustries.Add("Insurance", new List<string>() { "Agriculture", "Health", "Insurace (General)", "Life", "Vehicle" });
            _AllIndustries.Add("Legal", new List<string>() { "Judiciary", "Law Enforcement", "Law Practice", "Legal (General)", "Legal Services", "Legislative Office" });
            _AllIndustries.Add("Manufacturing", new List<string>() { "Business Supplies/Equipment", "Chemicals", "Consumer Electronics", "Consumer Goods", "Electrical/Electronic Manufacturing", "Food Production", "Furniture", "Glass/Ceramics/Concrete", "Industrial Automation", "Machinery", "Manufacturing (General)", "Mechanical/Industrial Engineering", "Mining/Metals", "Packaging/Containers", "Paper/Forest Products", "Plastics", "Shipbuilding", "Textiles" });
            _AllIndustries.Add("Media", new List<string>() { "Animation", "Arts/Crafts", "Broadcast Media", "Computer Games", "Design", "Fine Art", "Graphic Design", "Information Services", "Libraries", "Media (General)", "Media Production", "Motion Pictures/Film", "Museums/Institutions", "Newspapers", "Online Publishing", "Performing Arts", "Photography", "Printing", "Publishing", "Writing/Editing" });
            _AllIndustries.Add("Non-Profit/Organizations", new List<string>() { "Alternative Dispute Resolution", "Civic/Social Organization", "Consumer Services", "Environmental Services", "Fundraising", "Individual/Family Services", "Non-Profit Organization Management", "Non-Profit/Organizations (General)", "Philanthropy", "Political Organization", "Program Development", "Religious Institutions", "Security/Investigations", "Think Tanks" });
            _AllIndustries.Add("Real Estate", new List<string>() { "Commercial Real Estate", "Mortgage", "Property Management", "Real Estate (General)", "Residential Real Estate" });
            _AllIndustries.Add("Retail and Consumer Goods", new List<string>() { "Apparel/Fashion", "Consumer Electronics", "Consumer Goods", "Cosmetics", "eCommerce", "Food Production", "Furniture", "Luxury Goods/Jewelry", "Manufacturing Retail", "Packaging/Containers", "Retail", "Retail and Consumer Goods (General)", "Sporting Goods", "Supermarkets", "Tobacco", "Wholesale", "Wine/Spirits" });
            _AllIndustries.Add("Service Industry", new List<string>() { "Alternative Dispute Resolution", "Events Services", "Facilities Services", "Food/Beverages", "Package/Freight Delivery", "Restaurants", "Security/Investigations", "Service Industry (General)" });
            _AllIndustries.Add("Telecommunications", new List<string>() { "Cable and Other Program Distribution", "Communication Equipment", "Diversified Communication Services", "Long Distance Carriers", "Paging", "Processing Systems/Products", "Satellite Telecommunications", "Telecom Services - Domestic", "Telecom Services - Foreign", "Telecommunications (General)", "Wired Telecommunications Carriers", "Wireless Communications" });
            _AllIndustries.Add("Transportation and Logistics", new List<string>() { "Import/Export", "International Trade/Development", "Logistics/Supply Chain", "Maritime", "Package/Freight Delivery", "Translation/Localization", "Transportation and Logistics (General)", "Transportation/Trucking/Railroad", "Warehousing" });
            _AllIndustries.Add("Travel/Hospitality/Entertainment", new List<string>() { "Entertainment", "Food/Beverages", "Gambling/Casinos", "Hospitality", "Leisure/Travel", "Libraries", "Museums/Institutions", "Music", "Performing Arts", "Printing", "Publishing", "Recreational Facilities/Services", "Restaurants", "Sports", "Travel/Hospitality/Entertainment (General)", "Wine/Spirits" });
            _AllIndustries.Add("Utility/Energy", new List<string>() { "Electrical Power", "Gas", "Nuclear", "Oil", "Petroleum", "Power Distributors", "Power Generation", "Renewable Energy", "Utility/Energy (General)", "Waste Management", "Water Treatment" });
        }
    }
}
