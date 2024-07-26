using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._0
{
    public class FragmentInfo
    {
        public string Zone
        {
            get; set;
        }
        public string SubZone
        {
            get; set;
        }
        public string Element
        {
            get; set;
        }
        public int Monomer
        {
            get; set;
        }
        public int Polymer
        {
            get; set;
        }
        public int Inorganic
        {
            get; set;
        }
        public int Organic
        {
            get; set;
        }
    }

    public class Fragmentdatabase
    {
        private List<FragmentInfo> fragmentInfos;

        public Fragmentdatabase()
        {
            fragmentInfos = new List<FragmentInfo>
            {
                new FragmentInfo { Zone = "Kingston",               SubZone = "Grand Square",       Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Sterile Land",           SubZone = "Rockfall",           Element = "Electric",       Monomer = 4,    Polymer = 1,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "Sterile Land",           SubZone = "Repository",         Element = "Electric",       Monomer = 4,    Polymer = 0,    Inorganic = 1,  Organic = 0 },
                new FragmentInfo { Zone = "Sterile Land",           SubZone = "Restricted Zone",    Element = "Fire",           Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Sterile Land",           SubZone = "Ironworks",          Element = "Chill",          Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Vespers",                SubZone = "The Ruins",          Element = "Chill",          Monomer = 1,    Polymer = 4,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "Vespers",                SubZone = "Lost Supply Depot",  Element = "Fire",           Monomer = 0,    Polymer = 4,    Inorganic = 0,  Organic = 1 },
                new FragmentInfo { Zone = "Vespers",                SubZone = "Moonlight Lake",     Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Vespers",                SubZone = "Timberfall",         Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Echo Swamp",             SubZone = "Muskeg Swamp",       Element = "Fire",           Monomer = 1,    Polymer = 0,    Inorganic = 0,  Organic = 4 },
                new FragmentInfo { Zone = "Echo Swamp",             SubZone = "Derelict Covert",    Element = "Toxic",          Monomer = 0,    Polymer = 0,    Inorganic = 4,  Organic = 1 },
                new FragmentInfo { Zone = "Echo Swamp",             SubZone = "Abandoned Zone",     Element = "Toxic",          Monomer = 0,    Polymer = 1,    Inorganic = 4,  Organic = 0 },
                new FragmentInfo { Zone = "Agna Desert",            SubZone = "Vermilion Waste",    Element = "Electric",       Monomer = 0,    Polymer = 0,    Inorganic = 1,  Organic = 4 },
                new FragmentInfo { Zone = "Agna Desert",            SubZone = "The Storage",        Element = "Fire",           Monomer = 1,    Polymer = 0,    Inorganic = 0,  Organic = 4 },
                new FragmentInfo { Zone = "Agna Desert",            SubZone = "Miragestone",        Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Agna Desert",            SubZone = "The Mining Site",    Element = "Electric",       Monomer = 4,    Polymer = 1,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "White-night Gulch",      SubZone = "The Mountaintops",   Element = "Toxic",          Monomer = 0,    Polymer = 1,    Inorganic = 4,  Organic = 0 },
                new FragmentInfo { Zone = "White-night Gulch",      SubZone = "Observatory",        Element = "Chill",          Monomer = 1,    Polymer = 4,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "White-night Gulch",      SubZone = "Hatchery",           Element = "Fire",           Monomer = 0,    Polymer = 1,    Inorganic = 0,  Organic = 4 },
                new FragmentInfo { Zone = "White-night Gulch",      SubZone = "Moongrave Basin",    Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "White-night Gulch",      SubZone = "Shipment Base",      Element = "Toxic",          Monomer = 0,    Polymer = 0,    Inorganic = 4,  Organic = 1 },
                new FragmentInfo { Zone = "Hagios",                 SubZone = "Dune Base",          Element = "Fire",           Monomer = 1,    Polymer = 0,    Inorganic = 0,  Organic = 4 },
                new FragmentInfo { Zone = "Hagios",                 SubZone = "The Corrupted Zone", Element = "Fire",           Monomer = 0,    Polymer = 1,    Inorganic = 0,  Organic = 4 },
                new FragmentInfo { Zone = "Hagios",                 SubZone = "Fractured Monolith", Element = "Non-Attribute",  Monomer = 1,    Polymer = 1,    Inorganic = 1,  Organic = 1 },
                new FragmentInfo { Zone = "Fortress",               SubZone = "Frozen Valley",      Element = "Chill",          Monomer = 0,    Polymer = 4,    Inorganic = 0,  Organic = 1 },
                new FragmentInfo { Zone = "Fortress",               SubZone = "Fallen Ark",         Element = "Electric",       Monomer = 4,    Polymer = 0,    Inorganic = 1,  Organic = 0 },
                new FragmentInfo { Zone = "Fortress",               SubZone = "Defense Line",       Element = "Chill",          Monomer = 1,    Polymer = 4,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "[H] Kingston",           SubZone = "Grand Square",       Element = "Non-Attribute",  Monomer = 3,    Polymer = 3,    Inorganic = 3,  Organic = 4 },
                new FragmentInfo { Zone = "[H] Sterile Land",       SubZone = "Rockfall",           Element = "Electric",       Monomer = 11,   Polymer = 4,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "[H] Sterile Land",       SubZone = "Repository",         Element = "Electric",       Monomer = 12,   Polymer = 0,    Inorganic = 3,  Organic = 0 },
                new FragmentInfo { Zone = "[H] Sterile Land",       SubZone = "Restricted Zone",    Element = "Fire",           Monomer = 3,    Polymer = 4,    Inorganic = 3,  Organic = 3 },
                new FragmentInfo { Zone = "[H] Sterile Land",       SubZone = "Ironworks",          Element = "Chill",          Monomer = 4,    Polymer = 3,    Inorganic = 3,  Organic = 3 },
                new FragmentInfo { Zone = "[H] Vespers",            SubZone = "The Ruins",          Element = "Chill",          Monomer = 4,    Polymer = 11,   Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "[H] Vespers",            SubZone = "Lost Supply Depot",  Element = "Fire",           Monomer = 0,    Polymer = 13,   Inorganic = 0,  Organic = 2 },
                new FragmentInfo { Zone = "[H] Vespers",            SubZone = "Moonlight Lake",     Element = "Non-Attribute",  Monomer = 3,    Polymer = 3,    Inorganic = 3,  Organic = 4 },
                new FragmentInfo { Zone = "[H] Vespers",            SubZone = "Timberfall",         Element = "Non-Attribute",  Monomer = 3,    Polymer = 4,    Inorganic = 3,  Organic = 3 },
                new FragmentInfo { Zone = "[H] Echo Swamp",         SubZone = "Muskeg Swamp",       Element = "Fire",           Monomer = 1,    Polymer = 0,    Inorganic = 0,  Organic = 14 },
                new FragmentInfo { Zone = "[H] Echo Swamp",         SubZone = "Derelict Covert",    Element = "Toxic",          Monomer = 0,    Polymer = 0,    Inorganic = 13, Organic = 2 },
                new FragmentInfo { Zone = "[H] Echo Swamp",         SubZone = "Abandoned Zone",     Element = "Toxic",          Monomer = 0,    Polymer = 4,    Inorganic = 11, Organic = 0 },
                new FragmentInfo { Zone = "[H] Agna Desert",        SubZone = "Vermilion Waste",    Element = "Electric",       Monomer = 0,    Polymer = 0,    Inorganic = 2,  Organic = 13 },
                new FragmentInfo { Zone = "[H] Agna Desert",        SubZone = "The Storage",        Element = "Fire",           Monomer = 3,    Polymer = 0,    Inorganic = 0,  Organic = 12 },
                new FragmentInfo { Zone = "[H] Agna Desert",        SubZone = "Miragestone",        Element = "Non-Attribute",  Monomer = 4,    Polymer = 3,    Inorganic = 3,  Organic = 3 },
                new FragmentInfo { Zone = "[H] Agna Desert",        SubZone = "The Mining Site",    Element = "Electric",       Monomer = 14,   Polymer = 1,    Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "[H] White-night Gulch",  SubZone = "The Mountaintops",   Element = "Toxic",          Monomer = 0,    Polymer = 2,    Inorganic = 13, Organic = 0 },
                new FragmentInfo { Zone = "[H] White-night Gulch",  SubZone = "Observatory",        Element = "Chill",          Monomer = 2,    Polymer = 13,   Inorganic = 0,  Organic = 0 },
                new FragmentInfo { Zone = "[H] White-night Gulch",  SubZone = "Hatchery",           Element = "Fire",           Monomer = 0,    Polymer = 2,    Inorganic = 0,  Organic = 13 },
                new FragmentInfo { Zone = "[H] White-night Gulch",  SubZone = "Moongrave Basin",    Element = "Non-Attribute",  Monomer = 3,    Polymer = 3,    Inorganic = 4,  Organic = 3 },
                new FragmentInfo { Zone = "[H] White-night Gulch",  SubZone = "Shipment Base",      Element = "Toxic",          Monomer = 0,    Polymer = 0,    Inorganic = 12, Organic = 3 },
                new FragmentInfo { Zone = "[H] Hagios",             SubZone = "Dune Base",          Element = "Fire",           Monomer = 3,    Polymer = 0,    Inorganic = 0,  Organic = 12 },
                new FragmentInfo { Zone = "[H] Hagios",             SubZone = "The Corrupted Zone", Element = "Fire",           Monomer = 0,    Polymer = 4,    Inorganic = 0,  Organic = 11 },
                new FragmentInfo { Zone = "[H] Hagios",             SubZone = "Fractured Monolith", Element = "Non-Attribute",  Monomer = 3,    Polymer = 3,    Inorganic = 3,  Organic = 4 },
                new FragmentInfo { Zone = "[H] Fortress",           SubZone = "Frozen Valley",      Element = "Chill",          Monomer = 0,    Polymer = 13,   Inorganic = 0,  Organic = 2 },
                new FragmentInfo { Zone = "[H] Fortress",           SubZone = "Fallen Ark",         Element = "Electric",       Monomer = 12,   Polymer = 0,    Inorganic = 3,  Organic = 0 },
                new FragmentInfo { Zone = "[H] Fortress",           SubZone = "Defense Line",       Element = "Chill",          Monomer = 4,    Polymer = 11,   Inorganic = 0,  Organic = 0 }
            };
        }

        public List<FragmentInfo> GetZonesByElement(string element)
        {
            return fragmentInfos
                .Where(info => info.Element.Equals(element, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<FragmentInfo> GetZonesByFragment(string fragmentType)
        {
            switch (fragmentType)
            {
                case "Monomer":
                    return fragmentInfos
                        .Where(info => info.Monomer > 0)
                        .OrderByDescending(info => info.Monomer)
                        .ToList();
                case "Polymer":
                    return fragmentInfos
                        .Where(info => info.Polymer > 0)
                        .OrderByDescending(info => info.Polymer)
                        .ToList();
                case "Inorganic":
                    return fragmentInfos
                        .Where(info => info.Inorganic > 0)
                        .OrderByDescending(info => info.Inorganic)
                        .ToList();
                case "Organic":
                    return fragmentInfos
                        .Where(info => info.Organic > 0)
                        .OrderByDescending(info => info.Organic)
                        .ToList();
                default:
                    return new List<FragmentInfo>();
            }
        }

        public List<FragmentInfo> GetZonesByElementAndFragment(string element, string fragmentType)
        {
            switch (fragmentType.ToLower())
            {
                case "monomer":
                    return fragmentInfos
                        .Where(info => info.Element.Equals(element, StringComparison.OrdinalIgnoreCase) && info.Monomer > 0)
                        .OrderByDescending(info => info.Monomer)
                        .ToList();
                case "polymer":
                    return fragmentInfos
                        .Where(info => info.Element.Equals(element, StringComparison.OrdinalIgnoreCase) && info.Polymer > 0)
                        .OrderByDescending(info => info.Polymer)
                        .ToList();
                case "inorganic":
                    return fragmentInfos
                        .Where(info => info.Element.Equals(element, StringComparison.OrdinalIgnoreCase) && info.Inorganic > 0)
                        .OrderByDescending(info => info.Inorganic)
                        .ToList();
                case "organic":
                    return fragmentInfos
                        .Where(info => info.Element.Equals(element, StringComparison.OrdinalIgnoreCase) && info.Organic > 0)
                        .OrderByDescending(info => info.Organic)
                        .ToList();
                default:
                    return new List<FragmentInfo>();
            }
        }
    }
}
