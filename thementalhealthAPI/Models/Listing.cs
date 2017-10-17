using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thementalhealthAPI.Models
{
    public class Listing
    {
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

        public Listing()
        {
            
        }

    }
}