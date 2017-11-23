using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual Nullable<int> UsuarioId { get; set; }

        public virtual Nullable<int> PostId { get; set; }


    }
}
