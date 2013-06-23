using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNC.Entities;

namespace RNC.Tools
{
    class Converter
    {
        public Gender stringToGender(string sex)
        {
            if (sex.ToLower().Trim().Equals("true") || sex.ToLower().Trim().StartsWith("m") || sex.ToLower().Trim().StartsWith("h"))
            {
                return Gender.Male;
            }
            else if (sex.ToLower().Trim().StartsWith("f"))
            {
                return Gender.Female;
            }
            else
            {
                return Gender.Unspecified;
            }
        }

        public Province stringToCity(string city)
        {
            Array provinces = Enum.GetValues(typeof(Province));
            foreach (Province province in provinces)
            {
                if (city.ToLower().Trim().Equals(province.ToString().ToLower().Trim()))
                {
                    return province;
                }
            }
            return Province.Unspecified;
        }

        public bool sexToBit(Gender sex)
        {
            if (sex == Gender.Male)
            {
                return true;
            }
            else if (sex == Gender.Female)
            {
                return false;
            }
            else
            {
                throw new Exception("Igitsina kitabaho....");
            }
        }
    }
}
