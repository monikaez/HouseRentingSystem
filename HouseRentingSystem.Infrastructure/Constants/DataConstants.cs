using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Constants
{
    public static  class DataConstants
    {
        public const int CategoryNameMaxLength = 50;
       
        //Title – a string with min length 10 and max length 50 (required)
        public const int HouseTitleMaxLength = 50;
        public const int HouseTitleMinLength = 10;

        //•	Address – a string with min length 30 and max length 150 (required)
        public const int HouseAddressMaxLength = 150;
        public const int HouseAddressMinLength = 30;
        //•	Description – a string with min length 50 and max length 500 (required)
        public const int HouseDescriptionMaxLength = 500;
        public const int HouseDescriptionMinLength = 50;

        //•	PricePerMonth – a decimal with min value 0 and max value 2000 (required)
        public const string HousePricePerMonthMaxLength = "2000.00";
        public const string HousePricePerMonthMinLength = "0.00";

        //•	PhoneNumber – a string with min length 7 and max length 15 (required)
        public const int AgentPhoneNumberMaxLength = 15;
        public const int AgentPhoneNumberMinLength = 7;

    }
}
