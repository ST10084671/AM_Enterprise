using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmarahKader_XactERP_Project.Database
{
    class User
    {
        [Key] // Primary Key
        public int UserId { get; set; } // Generating Gets and Sets
        public string uName { get; set; } // Generating Gets and Sets
        public string uSurname { get; set; } // Generating Gets and Sets
        public string uEmailAddress { get; set; } // Generating Gets and Sets
        public string uContactNumber { get; set; } // Generating Gets and Sets
        public string uUsername { get; set; } // Generating Gets and Sets
        public string uPassword { get; set; } // Generating Gets and Sets
        public string uConfirmPassword { get; set; } // Generating Gets and Sets
    }
}
