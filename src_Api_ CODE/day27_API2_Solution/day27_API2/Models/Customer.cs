using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("9188f2d1-394f-437f-9a9a-4f247703502f")]

namespace day27_API2.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }
        public string LastName { get; set; }

    }
}

////http://localhost:64909/api/Products

//[HttpGet]
//[Route("Product")]
//public async Task<List<Product>> GetProduct()
//{
//    string Baseurl = "http://localhost:64909/";   //http://localhost:27598/api/Weathers
//    var ProdInfo = new List<Product>();
//    using (var client = new HttpClient())
//    {
//        client.BaseAddress = new Uri(Baseurl);
//        client.DefaultRequestHeaders.Clear();
//        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//        HttpResponseMessage Res = await client.GetAsync("api/Products");
//        if (Res.IsSuccessStatusCode)
//        {
//            //Storing the response details recieved from web api   
//            var ProdResponse = Res.Content.ReadAsStringAsync().Result;
//            //Deserializing the response recieved from web api and storing into the Employee list  
//            ProdInfo = JsonConvert.DeserializeObject<List<Product>>(ProdResponse);
//        }
//        //returning the employee list to view  
//        return ProdInfo;
//    }
//}

