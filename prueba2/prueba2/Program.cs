SAPbobsCOM.Company company = new SAPbobsCOM.Company();
company.Server = "server_name";
company.CompanyDB = "database_name";
company.UserName = "username";
company.Password = "password";
company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;

int connectResult = company.Connect();
if (connectResult != 0)
{
    string error = company.GetLastErrorDescription();
    Console.WriteLine("Error connecting: " + error);
}
else
{
    Console.WriteLine("Connected successfully.");
}
