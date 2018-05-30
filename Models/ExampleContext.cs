using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mgm_app.Models {
    public class ExampleContext : DbContext {
        public ExampleContext (DbContextOptions<ExampleContext> options) : base (options) { }

        public DbSet<Example> Examples { get; set; }
    }
}