using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSquadra.Dominio.Models
{
    public class CartaoLeadAccpted : CartaoLead
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactEmail { get; set; }
    }
}
