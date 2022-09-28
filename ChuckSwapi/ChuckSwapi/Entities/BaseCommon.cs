using ChuckSwapi.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace ChuckSwapi.Entities
{
    public class BaseCommon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
