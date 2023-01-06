using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine's name can't be empty!")]
    public string Name { get; set; }

    public DateTime? LastServiced { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
    }
}