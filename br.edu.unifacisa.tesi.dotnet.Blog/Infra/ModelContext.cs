namespace Infra
{
    using Dominio;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        
        public ModelContext()
            : base("name=ModelContext")
        {
        }



        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}