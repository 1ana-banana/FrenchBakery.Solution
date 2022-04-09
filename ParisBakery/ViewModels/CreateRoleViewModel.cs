using System.ComponentModel.DataAnnotations;

namespace ParisBakery.ViewModels
{
  public class CreateRoleViewModel
  {
    [Required]
    public string RoleName { get; set; }
  }
}