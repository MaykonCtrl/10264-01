using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using _013_MVC_EF.Models;

namespace _013_MVC_EF
{
    [MetadataType(typeof(PessoaMetaData))]
    partial class Pessoa 
    {

        public string Cidade { get; set; }

    }
}