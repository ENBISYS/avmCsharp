# Enbisys.AVM - the C# library for the AVM

This is api client library for AVM (automated valuation machine) - https://avm.enbisys.com/

Get instant and accurate Property Valuations and Predictive Analytics with our AI and Big Data tools. And make smart decisions faster

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)


## Getting Started

```csharp
using System;
using System.Diagnostics;
using Enbisys.AVM.Api;
using Enbisys.AVM.Client;
using Enbisys.AVM.Model;

namespace Enbisys.AVM
{
    public class Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://avm.enbisys.com/api";
            Configuration.Default.ApiKey.Add("X-API-KEY", "SET YOUR TOKEN HERE!");

            var apiInstance = new DefaultApi(Configuration.Default);


            var requiredFeatures = new RequiredFeatures
            (
                "B1 1TB",
                NewOrResale.New,
                FloorLevel.Basement,
                160,
                PropertyType.Semidetachedhouse,
                6
            );

            var propertyFeatures = new PropertyFeatures
            (
                requiredFeatures
            );

            try
            {
                var result = apiInstance.GetFastValuation(propertyFeatures);
                var valuation = apiInstance.GetValuation(propertyFeatures);

                Console.WriteLine("Current price: " + result);
                Console.WriteLine("Price range is: " + valuation.PriceRangeFrom + " - " + valuation.PriceRangeTo);
            }
            catch (ApiException e)
            {
                Debug.Print(e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://avm.enbisys.com/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**GetFastValuation**](docs/DefaultApi.md#getfastvaluation) | **POST** /properties/getFastValuation | 
*DefaultApi* | [**GetValuation**](docs/DefaultApi.md#getvaluation) | **POST** /properties/getValuation | 


## Documentation for Models

 - [Model.AdditionalFeatures](docs/AdditionalFeatures.md)
 - [Model.BuiltForm](docs/BuiltForm.md)
 - [Model.EnergyEfficiency](docs/EnergyEfficiency.md)
 - [Model.EnergyRating](docs/EnergyRating.md)
 - [Model.FloorLevel](docs/FloorLevel.md)
 - [Model.LeaseholdOrFreehold](docs/LeaseholdOrFreehold.md)
 - [Model.NewOrResale](docs/NewOrResale.md)
 - [Model.Problem](docs/Problem.md)
 - [Model.PropertyFeatures](docs/PropertyFeatures.md)
 - [Model.PropertyType](docs/PropertyType.md)
 - [Model.RequiredFeatures](docs/RequiredFeatures.md)
 - [Model.RoofInsulation](docs/RoofInsulation.md)
 - [Model.RoofType](docs/RoofType.md)
 - [Model.Valuation](docs/Valuation.md)
 - [Model.ValuationPriceDistribution](docs/ValuationPriceDistribution.md)
 - [Model.WallInsulation](docs/WallInsulation.md)
 - [Model.WallType](docs/WallType.md)
 - [Model.WindowGlazingType](docs/WindowGlazingType.md)


## Documentation for Authorization


### ApiKeyAuth

- **Type**: API key

- **API key parameter name**: X-API-KEY
- **Location**: HTTP header

