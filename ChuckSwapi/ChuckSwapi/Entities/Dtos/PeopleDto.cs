using ChuckSwapi.Entities.Models;

namespace ChuckSwapi.Entities.Dtos
{
    public class PeopleDto: BasePeople
    {
        public string Created { get; set; }
        public string Edited { get; set; }
        public List<string> Films { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Species { get; set; }
        public List<string> StarShips { get; set; }
    }
}
