using System;
using System.ComponentModel.DataAnnotations;

namespace CapaNegocio
{
    public class Empleado
    {
        [Required(ErrorMessage = "Debe Ingresar un nombre ")]
        [StringLength(maximumLength: 100, ErrorMessage = "Hasta 100 caracteres")]
        public string Nombre { get; set; }
    }


}
