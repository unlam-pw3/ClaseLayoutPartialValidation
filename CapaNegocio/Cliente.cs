using System;
using System.ComponentModel.DataAnnotations;

namespace CapaNegocio
{
    public class Cliente
    {
        [Required(ErrorMessage = "Debe Ingresar una Razon Social ")]
        [StringLength(maximumLength: 100, ErrorMessage = "Hasta 100 caracteres")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Ingrese una Edad")]
        [Range(1, 100, ErrorMessage = "La Edad debe ser entre 1 y 100")]
        public int EdadCIO { get; set; }

        [Required(ErrorMessage = "Mail requerido")]
        [EmailAddress(ErrorMessage = "Formato incorrecto")]
        public string Email { get; set; }
        
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "solo mayusculas y minusculas para {0}")]
        public string UserName { get; set; }

        [Compare("Email", ErrorMessage = "El email no coincide")]
        public string ConfirmEmail { get; set; }

        //[Display(Name ="Comienzo de Actividad")]
        //[CustomFechaMenor(ErrorMessage ="La fecha debe ser menor al año actual") ]
        //public DateTime InicioActividad{ get; set; }
    }

    public class CustomFechaMenor : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime fecha = (DateTime)value;

            if (fecha.Year >= DateTime.Now.Year)
            {
                return false; 
            }
            return true; 
        }
    }
}
