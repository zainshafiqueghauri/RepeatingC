using System.ComponentModel.DataAnnotations;

namespace RepeatingC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationship between 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
