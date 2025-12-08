using System.Data.Entity;

namespace NetFrameWorkMVCEgitimi.Models
{
    public class UyeContext : DbContext
    {
        public DbSet<Uye> Uyeler { get; set; }

    }
}