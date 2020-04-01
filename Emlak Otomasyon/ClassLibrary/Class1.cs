using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Home
    {
        private int numberOfRooms, numberOfFloors, numberOfEstate, areaOfHome, calculatedDate, probableRent = 200;
        private string district,province;
        private DateTime dateOfConstruct;
        private bool activeStatus;
        public enum KindOf { Daire, Bahceli, Dubleks, Mustakil, Residence, Villa, Yazlik };
        private KindOf _KindOf;


        public void HomeKindOf(object homeKindOf)
        {
            string b = Convert.ToString(homeKindOf);
            _KindOf = (KindOf)Enum.Parse(typeof(KindOf), b, true);
        }
        public string KindOfInformation()
        {
            return Convert.ToString(_KindOf);
        }

        public Home()
        {
            numberOfRooms = 3;
            numberOfFloors = 1;
            areaOfHome = 90;
            district = "Çankaya";
        }
        public Home(string semt)
        {
            numberOfRooms = 3;
            numberOfFloors = 1;
            areaOfHome = 90;
            district = semt;
        }
        public Home(int odaSayisi)
        {
            numberOfRooms = odaSayisi;
            numberOfFloors = 1;
            areaOfHome = 90;
            district = "Çankaya";
        }
        public Home(int odaSayisi,int katSayisi)
        {
            numberOfRooms = odaSayisi;
            numberOfFloors = katSayisi;
            areaOfHome = 90;
            district = "Çankaya";
        }
        public Home(int odaSayisi, int katSayisi, int evAlan)
        {
            numberOfRooms = odaSayisi;
            numberOfFloors = katSayisi;
            areaOfHome = evAlan;
            district = "Çankaya";
        }           
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set {
                Database database = new Database();
                if (value < 0)
                {
                    numberOfRooms = 0;
                    database.keepLog("Oda Sayısı", value);
                }
                else
                {
                    numberOfRooms = value;
                    database.keepLog("Oda Sayısı", value);
                }
            }
        }
        public int NumberOfFloors
        {
            get { return numberOfFloors; }
            set
            { 
                Database database = new Database();
                database.keepLog("Kat Sayısı", value); 
                numberOfFloors = value; 
            }
        }
        public int NumberOfEstate
        {
            get { return numberOfEstate; }
            set 
            {
                Random rnd = new Random();
                numberOfEstate = value + rnd.Next(100, 998);
            }
        }
        public int AreaOfHome
        {
            get { return areaOfHome; }
            set 
            {
                Database database = new Database();
                database.keepLog("Ev Alanı", value);
                areaOfHome = value; 
            }
        }
        public DateTime DateOfConstruct
        {
            get { return dateOfConstruct; }
            set { dateOfConstruct = value; }
        }
        public bool ActiveStatus
        {
            get { return activeStatus; }
            set
            {
                if (value == true)
                    activeStatus = true;
                else
                    activeStatus = false;
            }
        }
        public int CalculateDate
        {
            get { return calculatedDate; }
            set
            {
                calculatedDate = DateTime.Now.Year - DateOfConstruct.Year + value;
            }
        }
        public int ProbableRent
        {
            get { return probableRent; }
            set { probableRent = CalculatePrice(value); }
        }
        public string District
        {
            get { return district; }
            set { district = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public virtual string homeInformation()
        {
            return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}",
                ActiveStatus, Province, District, NumberOfEstate, NumberOfRooms, NumberOfFloors, AreaOfHome, KindOfInformation(), CalculateDate, ProbableRent);
        }
        public int CalculatePrice(int odaSayisi)
        {
            Database database = new Database();
            return database.RoomCostDataBase(odaSayisi);
        }
    }
    public class Sale : Home
    {
        private int salePrice;
        
        public int SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }        
        public override string homeInformation()
        {
            return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}*{10}",
                ActiveStatus, Province, District, NumberOfEstate, NumberOfRooms, NumberOfFloors, AreaOfHome, KindOfInformation(),CalculateDate, ProbableRent, SalePrice);
        }
    }
    public class Rent : Home
    {
        private int rentPrice, deposit;
        public int RentPrice
        {
            get { return rentPrice; }
            set { rentPrice = value; }
        }
        public int Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public override string homeInformation()
        {
            return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}*{10}*{11}",
                ActiveStatus, Province, District, NumberOfEstate, NumberOfRooms, NumberOfFloors, AreaOfHome, KindOfInformation(), CalculateDate, ProbableRent, RentPrice, Deposit);
        }
    }
    
}
