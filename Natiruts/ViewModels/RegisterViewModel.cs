using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Natiruts.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Display(Name = " Nome")]
        [Required(ErrorMessage = "Informe seu nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Informe seu sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Role Name")]
        [Required(ErrorMessage = "Please select a role")]
        public string RoleName { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Informe seu telefone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Informe seu e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
