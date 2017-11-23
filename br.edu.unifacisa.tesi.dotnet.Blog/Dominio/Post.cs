using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Post
    {
        public int PostID { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime DataCastrado { get; set; }

        public virtual Nullable<int> UsuarioId { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Nullable<int> AreaId { get; set; }

        public Post()
        {
            this.Comentarios = new HashSet<Comentario>();

        }

        
    }
}
