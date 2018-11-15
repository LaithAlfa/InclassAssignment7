using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter11142018.Models;

namespace UnitConverter11142018.Controllers
{
    public class ConversionController : Controller
    {
      
        public IActionResult Index()
            {
                return View();
            }
        [HttpGet]
        public IActionResult Converter()
            {
                
                return View();
            }
    [HttpPost]
       public IActionResult DoConversion(ConverterViewModel model)
       {
            switch (model.ConversionType) {
                case "OuncestoPounds":
                    model.ConversionValue = (model.ValueToConvert * 0.0625m);                  
                    break;

                case "OuncestoGrams":   
                    model.ConversionValue = (model.ValueToConvert / 0.035274m);
                    break;
                case "OuncestoKilograms":
                    model.ConversionValue = (model.ValueToConvert / 35.274m);
                    break;
                case "PoundstoOunces":
                    model.ConversionValue = (model.ValueToConvert * 16.00m);
                   break;
                case "PoundstoGrams":
                    model.ConversionValue = (model.ValueToConvert / 0.0022046m);
                   break;
                case "PoundstoKilograms":
                    model.ConversionValue = (model.ValueToConvert / 2.2046m);
                   break;
                case "GramstoOunces":
                    model.ConversionValue = (model.ValueToConvert / 28.3495m);
                   break;
                case "GramstoPounds":
                    model.ConversionValue = (model.ValueToConvert / 453.59237m);
                   break;
                case "GramstoKilograms":
                    model.ConversionValue = (model.ValueToConvert / 1000.0m);
                   break;
                case "KilogramstoOunces":
                    model.ConversionValue = (model.ValueToConvert / 0.02834952m);
                   break;
                case "KilogramstoPounds":
                    model.ConversionValue = (model.ValueToConvert / 0.45359237m);
                    break;
                case "KilogramstoGrams":
                    model.ConversionValue = (model.ValueToConvert * 1000.0m);
                   break;
              
                case "MeterstoFeet":
                    model.ConversionValue = (model.ValueToConvert / 0.3048m);
                   break;
                case "MeterstoYards":
                    model.ConversionValue = (model.ValueToConvert * 1.0936m);
                    break;
                case "FeettoMeters":
                    model.ConversionValue = (model.ValueToConvert * 0.3048m);
                    break;
                case "FeettoYards":
                    model.ConversionValue = (model.ValueToConvert * 0.3333m);
                    break;
                case "YardstoMeters":
                    model.ConversionValue = (model.ValueToConvert / 1.0936m);
                    break;
                case "YardstoFeet":
                    model.ConversionValue = (model.ValueToConvert * 3.0m);
                   break;
                      case "CelciusToFahrenheit":
                    model.ConversionValue = ((model.ValueToConvert * 1.8m) + 32.0m);
                    break;
                case "CelciustoKelvin":
                    model.ConversionValue = ((model.ValueToConvert + 273.15m));
                    break;
                case "FahrenheittoCelcius":
                    model.ConversionValue = ((model.ValueToConvert - 32.0m) / 1.8m);
                    break;
                case "FahrenheittoKelvin":
                    model.ConversionValue = ((model.ValueToConvert + 459.67m) * (5.0m / 9.0m));
                   break;
                case "KelvintoFahrenheit":
                    model.ConversionValue = ((model.ValueToConvert * 1.8m) -459.67m);
                    break;
                case "KelvintoCelcius":
                    model.ConversionValue = (model.ValueToConvert - 273.15m);
                    break;
                  default:
                  break;
                

            }
            return View(model);
            
       }
    }
}
