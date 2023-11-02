using System.ComponentModel.DataAnnotations;

namespace RepeatingC.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //relation ship only Movie
        public List<Movie> Movies { get; set; }
    }
}
