using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSquadra.Dominio.Models
{
    public class CartaoLead
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Suburb { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
