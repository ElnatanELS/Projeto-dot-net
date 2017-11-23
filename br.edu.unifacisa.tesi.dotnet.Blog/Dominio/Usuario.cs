using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    
        public virtual ICollection<Comentario> Comentarios { get; set; }


        public Usuario()
        {
            this.Posts = new HashSet<Post>();
            this.Comentarios = new HashSet<Comentario>();
        }

    }
}
