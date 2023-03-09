using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Areas.Address.Models
{
    public class cat_codigo_postal
    {
        [Key]
        [Column("id_codigo_postal")]
        [Display(Name = "ID IdCodigo Postal")]
        public int id_codigo_postal { get; set; }

        [DataType(DataType.Text)]
        public string? d_codigo { get; set; }

        [DataType(DataType.Text)]
        public string? d_asenta { get; set; }

        [DataType(DataType.Text)]
        public string? d_tipoAsenta { get; set; }

        [DataType(DataType.Text)]
        public string? d_mnpio { get; set; }

        [DataType(DataType.Text)]
        public string? d_estado { get; set; }

        [DataType(DataType.Text)]
        public string? d_ciudad { get; set; }

        [DataType(DataType.Text)]
        public string? d_cp { get; set; }

        [DataType(DataType.Text)]
        public string? c_estado { get; set; }

        [DataType(DataType.Text)]
        public string? c_oficina { get; set; }

        [DataType(DataType.Text)]
        public string? c_cp { get; set; }

        [DataType(DataType.Text)]
        public string? c_tipoAsenta { get; set; }

        [DataType(DataType.Text)]
        public string? c_mnpio { get; set; }

        [DataType(DataType.Text)]
        public string? id_asenta_cpcons { get; set; }

        [DataType(DataType.Text)]
        public string? d_zona { get; set; }

        [DataType(DataType.Text)]
        public string? c_cveCiudad { get; set; }
    }
}
