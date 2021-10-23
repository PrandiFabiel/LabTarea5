using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroConDetalle.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }
        public string DescripcionPermiso { get; set; }
<<<<<<< HEAD
        public int VecesAsignado { get; set; }
=======
>>>>>>> d19813d0649443f7847ccb4989996fa85b9b6d62
    }
}
