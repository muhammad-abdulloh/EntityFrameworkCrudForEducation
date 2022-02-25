using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEF.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Raiting { get; set; }


        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
