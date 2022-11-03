using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VisTu.Areas.Identity.Data;

// Add profile data for application users by adding properties to the VisTuUsuario class
public class VisTuUsuario : IdentityUser
{
    [MaxLength(20), MinLength(3)]
    [Required(ErrorMessage = "Favor informar seu nome")]
    public string Nome { get; set; }
    [MaxLength(50), MinLength(3)]
    [Required(ErrorMessage = "Favor informar o sobrenome")]
    public string Sobrenome { get; set; }
}

