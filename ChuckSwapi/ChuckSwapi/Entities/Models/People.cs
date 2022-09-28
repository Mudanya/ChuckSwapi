using System.ComponentModel.DataAnnotations;

namespace ChuckSwapi.Entities.Models
{
    public class People : BasePeople
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public List<Film> Films { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Species> Species { get; set; }
        public List<Starship> StarShips { get; set; }
    }
}
