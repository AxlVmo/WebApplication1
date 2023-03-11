using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppAdmin.Areas.Address.Models
{
    public class usuario_control
    {
        [Key]
        public Guid id_usuario_control { get; set; }
        [Display(Name = "Nombres")]
        public string nombres { get; set; } = string.Empty;
        [Display(Name = "Apellido Paterno")]
        public string apellido_paterno { get; set; } = string.Empty;
        [Display(Name = "ApellidoMaterno")]
        public string apellido_materno { get; set; } = string.Empty;
        [Display(Name = "Nombre Usuario")]
        public string nombre_usuario { get; set; } = string.Empty;

        [Display(Name = "Area")]
        public System.Nullable<System.Int32>  id_area { get; set; } 
        [Display(Name = "Genero")]
        public System.Nullable<System.Int32>  id_genero { get; set; }
        [Display(Name = "Perfil")]
        public System.Nullable<System.Int32>  id_perfil { get; set; }
        [Display(Name = "Rol")]
        public System.Nullable<System.Int32>  id_rol { get; set; }
        public bool  terminos_uso { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }
        [Display(Name = "Correo de Acceso")]

        public string correo_acceso { get; set; } = string.Empty;

        [Display(Name = "Rol")]
        public byte[]? profile_picture { get; set; } 
        [Display(Name = "Usuario Modifico")]
        public Guid id_usuario_modifico { get; set; }

        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        public DateTime fecha_registro { get; set; }

        [Display(Name = "Fecha de Actualizacion")]
        [DataType(DataType.Date)]
        public DateTime fecha_actualizacion { get; set; }
        [Display(Name = "Estatus")]

        public System.Nullable<System.Int32>  id_estatus_registro { get; set; }

    }
}
