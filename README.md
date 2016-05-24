# WCF REST API Service

This project demonstrates an eays to maintain REST API service to query sql databases and return data as json or xml.
Adventure Works 2014 Database provided by Microsoft is used for demonstration purpose. 
Adventure Works DB can be obtained here: https://msftdbprodsamples.codeplex.com/releases/view/125550

## Usage

#### Web.config (contains db connection string)

  <connectionStrings>
    <add name="ADW2014" connectionString="Data Source=localhost;Initial Catalog=AdventureWorks2014;Integrated Security=True"/>
  </connectionStrings>
  
#### IService1.cs

In IService1.cs file the operation contracts are declared. Operation contracts define the url request endpoints, return the requested data.

  [OperationContract]
  [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SalesvSalesPerson")]
  List<SalesPersonObject> SalesvSalesPerson();

  UriTemplate = Your Request endpoint e.g.: http://yoururl.com/SalesvSalesPerson
  ResponseFormat/RequestFormat = Json/XML
  
The return data is defined as a list of DataContracts. It is received from the method SalesvSalesPerson() declared in Service1.svc.cs file.

A data contract is a class containig the requested sql table cloumns as properties.
In this demo SalesPersonObject and IndividualCustomerObject are declared.


#### Service1.svc.cs

This is where the magic happens.

QueryDB method and FillProperties are generic methods to query the sql server and receive the requestet data.
Do not change anything here.

For every OperationContract a unique Method must be declared in to return the requested data.

  public List<SalesPersonObject> SalesvSalesPerson()
  {
      _connnection = ConfigurationManager.ConnectionStrings["ADW2014"].ConnectionString;
      return QueryDB<SalesPersonObject>("Select * From Sales.vSalesPerson");
  }

Set the connection string from the web.config.
Create a query and pass it with the created data contract to the QueryDB method.


