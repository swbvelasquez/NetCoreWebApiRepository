using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiRepository.Models
{   
    [Table("WAR_Usuario")]
    public class Usuario
    {
        [Key]
        [Column("WAR_IdUsuario")]
        public long IdUsuario { get; set; }

        [Column("WAR_Clave")]
        public String Clave { get; set; }

        [Column("WAR_Nombre")]
        public String Nombre { get; set; }

        [Column("WAR_ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }

        [Column("WAR_ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [Column("WAR_Edad")]
        public int Edad { get; set; }

        [Column("WAR_CorreoElectronico")]
        public String CorreoElectronico { get; set; }

        [Column("WAR_NroCelular")]
        public String NroCelular { get; set; }

        [Column("WAR_IdVoto")]
        public long IdVoto { get; set; }

        [ForeignKey("WAR_IdVoto")]
        public virtual Voto Voto { get; set; }
    }
}
