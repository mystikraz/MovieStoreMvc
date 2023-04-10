using Microsoft.Build.Framework;
using System.Reflection.Metadata;

namespace MovieStoreMvc.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string?  GenreName { get; set; }
    }
}
