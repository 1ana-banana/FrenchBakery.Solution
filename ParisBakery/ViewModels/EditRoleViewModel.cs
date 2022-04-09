using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParisBakery.ViewModels
{
  public class EditRoleViewModel
  {
    public EditRoleViewModel()
    {
      Users = new List<string>();
    }
    public string Id { get; set; }
    
    [Required(ErrorMessage = "You need to type in a Role Name.")]
    public string RoleName { get; set; }
    public List<string> Users { get; set; }
  }
}