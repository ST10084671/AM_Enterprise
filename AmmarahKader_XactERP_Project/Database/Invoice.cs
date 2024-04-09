using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmarahKader_XactERP_Project.Database
{
    class Invoice
    {
        [Key] // Primary Key
        public int InvoiceId { get; set; } // Generating Gets and Sets
        public string iAccountCode { get; set; } // Generating Gets and Sets
        public DateTime iDate { get; set; } // Generating Gets and Sets
        public string iTotalSell { get; set; } // Generating Gets and Sets
        public string iVat { get; set; } // Generating Gets and Sets
        public string iNumber { get; set; } // Generating Gets and Sets
        public string iItemNumber { get; set; } // Generating Gets and Sets
        public string iStockCode { get; set; } // Generating Gets and Sets
        public int iQtySold { get; set; } // Generating Gets and Sets
        public decimal iUnitCost { get; set; } // Generating Gets and Sets
        public decimal iUnitSell { get; set; } // Generating Gets and Sets
        public decimal iDiscount { get; set; } // Generating Gets and Sets
        public decimal iTotal { get; set; } // Generating Gets and Sets
        public string iTransactionType { get; set; } // Generating Gets and Sets
        public string iDocumentNumber { get; set; } // Generating Gets and Sets
    }
}
