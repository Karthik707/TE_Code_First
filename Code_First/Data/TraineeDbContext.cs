using Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_First.Data
{
    public class TraineeDbContext:DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
