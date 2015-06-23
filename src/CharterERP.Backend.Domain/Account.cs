using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Domain.Entities
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        [Column("Bill_Date")]
        public DateTime BillDate { get; set; }

    }
}
