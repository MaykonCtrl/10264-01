using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _010_Pessoa.Models
{
    public class Pessoa
    {

        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
        public List<Endereco> Enderecos { get;set;}
        
    }

    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
    }

}
