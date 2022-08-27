using System;
using System.Collections.Generic;

namespace PensePositivoAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nacionality { get; set; }
        public DateTime? BirthDate { get; set; }        
    }
}