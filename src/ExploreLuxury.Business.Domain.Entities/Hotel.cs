using System;

namespace ExploreLuxury.Business.Domain.Entities
{
    public enum HotelRatingCategory
    { 
        OnceStar, 
        TwoStar, 
        ThreeStar, 
        FourStar, 
        FiveStar
    };

    public class Hotel
    {
        public HotelRatingCategory? HotelRatingCategory
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }

        public string Name 
        { 
            get; set;         
        }

        public string ShortDescription
        {
            get;
            set;
        }

        

        /*public Guid AddressId
        {
            get;
            set;
        }

        public virtual Address Address
        { 
            get; 
            set; 
        }*/
    }
}
