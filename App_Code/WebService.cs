using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DsFarmaciaTableAdapters;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    [WebMethod]
    public String Consulta1() {
        Vista1TableAdapter objt1 = new Vista1TableAdapter();
        DsFarmacia DatosR = new DsFarmacia();
        objt1.Consulta1(DatosR.Vista1);
        String JSONString = String.Empty;
        JSONString = JsonConvert.SerializeObject(DatosR);
        return JSONString;
    }
}
