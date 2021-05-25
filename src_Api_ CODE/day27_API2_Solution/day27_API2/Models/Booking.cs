using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("9ce76072-f378-4502-89da-c264d4e78f70")]
namespace day27_API2.Models
{
    public class Booking
    {
        [Key]
        public int Order_ID { get; set; }   
        public float Amount { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string OrderTime { get; set; }
        public string DeliveryTime { get; set; }

    }
}


