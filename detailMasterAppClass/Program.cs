using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailMasterAppClass
{
    class Program
    {
        public enum RealEstateType
        {
            NONE,
            COMMERCIAL,
            RESIDENTIAL
        }

        private string _location; 
        private int _bedrooms;
        private int _bathrooms;
        private double _squareFootage;
        private double _lotSize;
        private double _price;
        private int _yearBuilt;
        private double _yearlyTaxes;
        private string _propertyType;
        private RealEstateType _typeOfRealEstate;
        private string _buildingClass;
        private string _saleType;
        private string _parcelID;
        private int _numberOfStories;

        public int NumberOfStories
        {
            get { return _numberOfStories; }
            set { _numberOfStories = value; }
        }

        public string ParcelID
        {
            get { return _parcelID; }
            set { _parcelID = value; }
        }

        public string SaleType
        {
            get { return _saleType; }
            set { _saleType = value; }
        }

        public string BuildingClass
        {
            get { return _buildingClass; }
            set { _buildingClass = value; }
        }

        public RealEstateType TypeOfRealEstate
        {
            get { return _typeOfRealEstate; }
            set { _typeOfRealEstate = value; }
        }

        public string PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        public double YearlyTaxes
        {
            get { return _yearlyTaxes; }
            set { _yearlyTaxes = value; }
        }

        public int BuildDate
        {
            get { return _yearBuilt; }
            set { _yearBuilt = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double LotSize
        {
            get { return _lotSize; }
            set { _lotSize = value; }
        }

        public double SquareFootage
        {
            get { return _squareFootage; }
            set { _squareFootage = value; }
        }

        public int Bathrooms
        {
            get { return _bathrooms; }
            set { _bathrooms = value; }
        }

        public int Bedrooms
        {
            get { return _bedrooms; }
            set { _bedrooms = value; }
        }

    }
}
