using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{

  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The Engineer name field can't be empty!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Engineer's hire date can't be empty!")]
    public DateTime? DateHired  { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}