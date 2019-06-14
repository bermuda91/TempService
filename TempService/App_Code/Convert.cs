using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Convert
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Convert : System.Web.Services.WebService
{

    public Convert()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello Worldd";
    } 

    [WebMethod]
    public double FahrenheitToCensius(double Fahrenheit)
    {
        return ((Fahrenheit - 32) * 5) / 9;
    }

    [WebMethod]
    public double CensiusToFahrenheit(double Censius)
    {
        return ((Censius * 9) / 5) + 32;
    }


}
