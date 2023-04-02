using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Models
{
    public class Gender
    {
       
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
