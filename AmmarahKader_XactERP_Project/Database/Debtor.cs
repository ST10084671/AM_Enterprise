using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmarahKader_XactERP_Project.Database
{
    class Debtor
    {
        [Key] // Primary Key
        public int DebtorId { get; set; } // Generating Gets and Sets
        public string dAccountCode { get; set; } // Generating Gets and Sets
        public string dAddressOne { get; set; } // Generating Gets and Sets
        public string dAddressTwo { get; set; } // Generating Gets and Sets
        public string dAddressThree { get; set; } // Generating Gets and Sets
        public string dCategory { get; set; } // Generating Gets and Sets
        public string dInvoiceType { get; set; } // Generating Gets and Sets
        public string dContactNumberOne { get; set; } // Generating Gets and Sets
        public string dContactNumberTwo { get; set; } // Generating Gets and Sets
        public decimal dBalance { get; set; } // Generating Gets and Sets
        public decimal dSalesYearToDte { get; set; } // Generating Gets and Sets
        public decimal dCostYearToDate { get; set; } // Generating Gets and Sets
        public decimal dCreditLimit { get; set; } // Generating Gets and Sets
    }
}