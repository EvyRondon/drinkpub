using drink.Model;
using System.ComponentModel.DataAnnotations;

namespace drink.Model
{
    public class people
    {
        public people()
        {
            address = new address();
            phone = new phone();
        }

        public int id { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório")]
        public string name { get; set; }

        [Required(ErrorMessage ="Número de identificação é obrigatório")]
        public string document { get; set; }

        public string email { get; set; }

        public phone phone { get; set; }
        public address address { get; set; } 
    }
}
