using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Costtype
    {
        [Key]
        public int CostId { get; set; }
        public int CostMapId { get; set; }
        public string Costtittle { get; set; }
        [NotMapped]
        public string OperationType { get; set; }
    }
}
