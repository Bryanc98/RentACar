using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RentACar.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Modelo> Modelos { get; set; }

        public DbSet<TipoCombustible> TipoCombustibles { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Inspeccion> Inspeccions { get; set; }

        public DbSet<RentaDevolucion> RentaDevolucions { get; set; }

        public DbSet<Combustible> Combustibles { get; set; }

        public DbSet<Gato> Gatos { get; set; }

        public DbSet<GomaRepuesto> GomaRepuestos { get; set; }

        public DbSet<Ralladura> Ralladuras { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<RoturaCristal> RoturaCristals { get; set; }

        public DbSet<TipoPersona> TipoPersonas { get; set; }



    }
}