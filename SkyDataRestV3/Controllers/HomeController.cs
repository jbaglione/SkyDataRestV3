using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyDataRestV3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

//Clientes
//{"clientes":
//  [{
//    "id": 8630,
//    "abreviatura": "0004",
//    "razonSocial": "ASOCIACION COSTARRICENSE DE ORGANIZACIONES PARA EL DESARROLLO DE COSTA RICA S.A.",
//    "rubroDesc": "ÁREA PROTEGIDA 24/7",
//    "dmCalle": "San José",
//    "dmAltura": 100,
//    "dmPiso": null,
//    "dmDepto": null,
//    "localidadId": 20006,
//    "localidadDesc": "DISTRITO MERCED",
//    "codigoPostal": null,
//    "dmEntreCalle1": "CARMEN",
//    "dmEntreCalle2": null,
//    "dmReferencia": "Del Automercado San José Calle 3 Ave. 5-7 Edificio ACORDE",
//    "dmLatitud": "9.928069",
//    "dmLongitud": "-84.090725",
//    "cuit": "3002084110",
//    "fecIngreso": "2002-10-29 00:00:00.000",
//    "fecEgreso": "2999-12-31 00:00:00.000",
//    "planDesc": "AREA PROTEGIDA 24/7",
//    "formaPagoDesc": "TRANSFERENCIA",
//    "cobradorDesc": "TRANSFERENCIA",
//    "nroContrato": null,
//    "vendedorDesc": "MORÚA CHINCHILLA OLGA MARTA",
//    "observaciones": null
//    },
//    {
//    "id": 8635,
//    "abreviatura": "14591",
//    "razonSocial": "ASOCIACION TESTIGOS DE JEHOVA",
//    "rubroDesc": "ÁREA PROTEGIDA 24/7",
//    "dmCalle": "HEREDIA BELEN",
//    "dmAltura": 0,
//    "dmPiso": null,
//    "dmDepto": null,
//    "localidadId": 30352,
//    "localidadDesc": "DISTRITO LA ASUNCION",
//    "codigoPostal": null,
//    "dmEntreCalle1": null,
//    "dmEntreCalle2": null,
//    "dmReferencia": "HEREDIA ASUNCION DE BELEN DE EPA 300 OESTE Y 700 NORTE EN PORTON DE SALON DE ASAMBLEAS",
//    "dmLatitud": "9.979719",
//    "dmLongitud": "-84.180438",
//    "cuit": "3002045312",
//    "fecIngreso": "2001-09-07 00:00:00.000",
//    "fecEgreso": "2999-12-31 00:00:00.000",
//    "planDesc": "AREA PROTEGIDA 24/7",
//    "formaPagoDesc": "COBRADOR",
//    "cobradorDesc": "LÓPEZ CASTRO MICHAEL",
//    "nroContrato": 1,
//    "vendedorDesc": "VENTAS OFICINA",
//    "observaciones": "14-07-15 Aumenta facturación AGO 15, se envia carta pasa de ¢69.000 a ¢71.000. KGS"
//  }]
//}

//ClientesIntegrantes
//{"clientesIntegrantes":
//  [{
//    "id": 78479,
//    "clienteId": 10150,
//    "tipoIntegrante": "DOM",
//    "integranteClasificacionDesc": "OTRO",
//    "nroAfiliado": "258152",
//    "apellido": "/",
//    "nombre": "CASA 1-004",
//    "tipoDocumentoDesc": "CÉDULA JURÍDICA",
//    "nroDocumento": 3002174338,
//    "nroPasaporte": null,
//    "fecNacimiento": "1899-12-30 00:00:00.000",
//    "sexo": null,
//    "dmCalle": "SAN JOSE",
//    "dmAltura": 0,
//    "dmPiso": null,
//    "dmDepto": null,
//    "localidadId": 20005,
//    "localidadDesc": "DISTRITO CARMEN",
//    "codigoPostal": null,
//    "dmEntreCalle1": null,
//    "dmEntreCalle2": null,
//    "dmReferencia": null,
//    "dmLatitud": "9.928069",
//    "dmLongitud": "-84.090725",
//    "telefono01": "8998-2325",
//    "telefono02": null,
//    "fecIngreso": "2017-12-19 00:00:00.000",
//    "fecEgreso": "2018-12-12 00:00:00.000",
//    "observaciones": "Se protege habitantes y visitas de la casa de Ernesto Gallo Covarrubeas",
//    "txtObservaciones": "11/12/18 la familia Gallo Torres se trasladó a la casa 1-133//OM"
//},
//{
//    "id": 129015,
//    "clienteId": 10654,
//    "tipoIntegrante": "PER",
//    "integranteClasificacionDesc": "OTRO",
//    "nroAfiliado": "225375",
//    "apellido": "OCON",
//    "nombre": "MAYERLING DEL ROSARIO",
//    "tipoDocumentoDesc": "PASAPORTE",
//    "nroDocumento": 11027851,
//    "nroPasaporte": null,
//    "fecNacimiento": "2013-09-09 00:00:00.000",
//    "sexo": "F",
//    "dmCalle": "San José",
//    "dmAltura": 0,
//    "dmPiso": null,
//    "dmDepto": null,
//    "localidadId": 20005,
//    "localidadDesc": "DISTRITO CARMEN",
//    "codigoPostal": null,
//    "dmEntreCalle1": null,
//    "dmEntreCalle2": null,
//    "dmReferencia": "De la Escuela Ezequiel Morales Aguilar 50 norte, tercera casa a mano derecha",
//    "dmLatitud": "9.928069",
//    "dmLongitud": "-84.090725",
//    "telefono01": "8308-5664",
//    "telefono02": null,
//    "fecIngreso": "2013-09-09 00:00:00.000",
//    "fecEgreso": "2019-04-01 00:00:00.000",
//    "observaciones": "Trato preferencial cliente vip, IR SIEMPRE.CM",
//    "txtObservaciones": "19/3/18 cambio afiliado baja 225375 ingresar a 155813231714."
//  }]
//}




