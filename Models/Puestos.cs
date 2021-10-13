using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace web_api_db.Models {
    public class Puestos {
        [Key]
        public int id_puesto {get; set;}
        public string puesto {get; set;}
        public List<Empleados> Empleados {get; set;}   
    }
}