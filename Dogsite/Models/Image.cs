using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dogsite.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        [StringLength(100)]
        public string ImageName { get; set; }

        [Required]
        [Column(TypeName = "varbinary(MAX)")]
        public byte[] ImageData { get; set; }
    }

    public class YourDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; } // DbSet for your Image model

        // Other DbSet properties for your other models, if any

        // Constructor to specify connection string
        public YourDbContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DogDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
    }
}