using systemsecurity.domain;


using Microsoft.EntityFrameworkCore;
using system.Security.API.Configuration.Entity;



namespace Academico.System.Configuration
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("system");
            //systema
            modelBuilder.ApplyConfiguration(new PlatformMigration());
            modelBuilder.ApplyConfiguration(new ApplicationMigration());
            modelBuilder.ApplyConfiguration(new RouteMigration());
            modelBuilder.ApplyConfiguration(new RoleMigration());
            modelBuilder.ApplyConfiguration(new UserMigration());
            modelBuilder.ApplyConfiguration(new EventMigration());
            modelBuilder.ApplyConfiguration(new ResourceMigration());
            modelBuilder.ApplyConfiguration(new RoutingMigration());
        }  

        
        public DbSet<systemsecurity.domain.Platform> Platform { get; set; }
        public DbSet<systemsecurity.domain.Application> Application { get; set; }
        public DbSet<systemsecurity.domain.Role> Role { get; set; }
        public DbSet<systemsecurity.domain.Route> Route { get; set; }
        public DbSet<systemsecurity.domain.Routing> Routing { get; set; }
        public DbSet<systemsecurity.domain.Resource> Resource { get; set; }
        public DbSet<systemsecurity.domain.Service> Service { get; set; }        
        public DbSet<systemsecurity.domain.Event> Event{ get; set; }
        public DbSet<systemsecurity.domain.User> User { get; set; }
    }


    //public DbSet<Usuario> Usuario { get; set; }
    //public DbSet<Role> Role { get; set; }
    //public DbSet<Credencial> Credenciais { get; set; }
    //  public DbSet<Organization> Organizacoes { get; set; }
    //public DbSet<RolesOrganizacao> RolesOrganizacao { get; set; }

    /*

    modelBuilder.ApplyConfiguration(new PessoaMigration());


    modelBuilder.Entity<Usuario>().OwnsOne(
        user1 => user1.Acesso, options =>
        {
            options.ToJson();

            options.OwnsMany(Acesso => Acesso.Credenciais,
            //    options => options.OwnsMany(a => a.AcessoOrganizacao,
                     options => options.OwnsMany(r => r.Roles));

        });            
    */

    //modelBuilder.Entity<Role>().OwnsOne(
    //    roles => roles.Rotas, options =>
    //    {
    //        options.ToJson();

    //        options.OwnsMany(subrotas => subrotas.SubRotas,
    //            options => options.OwnsMany(subrotas => subrotas.SubRotas)
    //        );

    //    });
    //old

}
