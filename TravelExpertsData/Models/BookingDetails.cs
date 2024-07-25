using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Models;


    public class BookingDetails
    {
        public int BookingDetailId { get; set; }
        public int BookingId { get; set; } // Reference to Booking table if exists
        public int ProductSupplierId { get; set; } // Foreign key to ProductsSuppliers
        public string Status { get; set; } 
        public decimal Price { get; set; } 

        // Navigation properties
        public virtual ProductsSupplier ProductSupplier { get; set; } // Relationship to ProductsSuppliers
                                                                      // Add other navigation properties if necessary
    }

