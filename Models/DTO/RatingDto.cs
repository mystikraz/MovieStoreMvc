using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreMvc.Models.Domain
{
    public class RatingDto
    {
        public int Id { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}
