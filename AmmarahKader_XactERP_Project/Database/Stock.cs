using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmarahKader_XactERP_Project.Database
{
    class Stock
    {
        [Key] // Primary Key
        public int StockId { get; set; } // Generating Ge=ts and Sets
        public string sCode { get; set; } // Generating Gets and Sets
        public string sDescriptionOne { get; set; } // Generating Gets and Sets
        public string sDescriptionTwo { get; set; } // Generating Gets and Sets
        public string sCategory { get; set; } // Generating Gets and Sets
        public string sInvoiceType { get; set; } // Generating Gets and Sets
        public decimal sCostPrice { get; set; } // Generating Gets and Sets
        public decimal sSellingPrice { get; set; } // Generating Gets and Sets
        public decimal sTotalPurchases { get; set; } // Generating Gets and Sets
        public decimal sTotalSales { get; set; } // Generating Gets and Sets
        public int sQtyPurchased { get; set; } // Generating Gets and Sets
        public int sQtySold { get; set; } // Generating Gets and Sets
        public int sOnHand { get; set; } // Generating Gets and Sets
    }
}