using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestApiSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SalesvSalesPerson")]
        List<SalesPersonObject> SalesvSalesPerson();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SalesvIndividualCustomer")]
        List<IndividualCustomerObject> SalesvIndividualCustomer();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SalesPersonObject
    {
        int _BusinessEntityID;
        string _Title;
        string _FirstName;
        string _MiddleName;
        string _LastName;
        string _Suffix;
        string _JobTitle;
        string _PhoneNumber;
        string _PhoneNumberType;
        string _EmailAddress;
        int _EmailPromotion;
        string _AddressLine1;
        string _AddressLine2;
        string _City;
        string _StateProvinceName;
        string _PostalCode;
        string _CountryRegionName;
        string _TerritoryName;
        string _TerritoryGroup;
        double _SalesQuota;
        double _SalesYTD;
        double _SalesLastYear;

        [DataMember]
        public int BusinessEntityID
        {
            get { return _BusinessEntityID; }
            set { _BusinessEntityID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public String Suffix
        {
            get { return _Suffix; }
            set { _Suffix = value; }
        }

        [DataMember]
        public String JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }

        [DataMember]
        public String PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        [DataMember]
        public String PhoneNumberType
        {
            get { return _PhoneNumberType; }
            set { _PhoneNumberType = value; }
        }

        [DataMember]
        public String EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }

        [DataMember]
        public int EmailPromotion
        {
            get { return _EmailPromotion; }
            set { _EmailPromotion = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public String City
        {
            get { return _City; }
            set { _City = value; }
        }

        [DataMember]
        public String StateProvinceName
        {
            get { return _StateProvinceName; }
            set { _StateProvinceName = value; }
        }

        [DataMember]
        public String PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }

        [DataMember]
        public String CountryRegionName
        {
            get { return _CountryRegionName; }
            set { _CountryRegionName = value; }
        }

        [DataMember]
        public String TerritoryName
        {
            get { return _TerritoryName; }
            set { _TerritoryName = value; }
        }

        [DataMember]
        public String TerritoryGroup
        {
            get { return _TerritoryGroup; }
            set { _TerritoryGroup = value; }
        }

        [DataMember]
        public Double SalesQuota
        {
            get { return _SalesQuota; }
            set { _SalesQuota = value; }
        }

        [DataMember]
        public Double SalesYTD
        {
            get { return _SalesYTD; }
            set { _SalesYTD = value; }
        }

        [DataMember]
        public Double SalesLastYear
        {
            get { return _SalesLastYear; }
            set { _SalesLastYear = value; }
        }
    }

    [DataContract]
    public class IndividualCustomerObject
    {
        int _BusinessEntityID;
        string _Title;
        string _FirstName;
        string _MiddleName;
        string _LastName;
        string _Suffix;
        string _PhoneNumber;
        string _PhoneNumberType;
        string _EmailAddress;
        int _EmailPromotion;
        string _AddressType;
        string _AddressLine1;
        string _AddressLine2;
        string _City;
        string _StateProvinceName;
        string _PostalCode;
        string _CountryRegionName;
        string _Demographics;

        [DataMember]
        public int BusinessEntityID
        {
            get { return _BusinessEntityID; }
            set { _BusinessEntityID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public String Suffix
        {
            get { return _Suffix; }
            set { _Suffix = value; }
        }

        [DataMember]
        public String PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        [DataMember]
        public String PhoneNumberType
        {
            get { return _PhoneNumberType; }
            set { _PhoneNumberType = value; }
        }

        [DataMember]
        public String EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }

        [DataMember]
        public int EmailPromotion
        {
            get { return _EmailPromotion; }
            set { _EmailPromotion = value; }
        }

        [DataMember]
        public String AddressType
        {
            get { return _AddressType; }
            set { _AddressType = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public String City
        {
            get { return _City; }
            set { _City = value; }
        }

        [DataMember]
        public String StateProvinceName
        {
            get { return _StateProvinceName; }
            set { _StateProvinceName = value; }
        }

        [DataMember]
        public String PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }

        [DataMember]
        public String CountryRegionName
        {
            get { return _CountryRegionName; }
            set { _CountryRegionName = value; }
        }

        [DataMember]
        public String Demographics
        {
            get { return _Demographics; }
            set { _Demographics = value; }
        }
    }
}
