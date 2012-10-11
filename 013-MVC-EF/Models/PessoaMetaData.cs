using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _013_MVC_EF.Models
{
    
    public class PessoaMetaData 
    {
        [DisplayName("Código:")]
        public int Codigo { get; set; }

        [Required]
        [DisplayName("Nome:")]
        public string Nome { get; set; }
        [Required(ErrorMessage="Campo Obrigatorio.....")]
        [DisplayName("Sexo:")]
        public char Sexo { get; set; }

    }
}