using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Entidades;

public class ApplicationUser : IdentityUser
{
    [Column("USR_CPF")]
    public string CPF { get; set; }
}