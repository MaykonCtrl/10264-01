using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _010_Pessoa.Models;

namespace _010_Pessoa
{
    public class PessoaDB
    {
        public static Pessoa[] Get()
        {
            return new Pessoa[]
            {
                new Pessoa{Codigo=1,Nome="Adao",SobreNome="",Idade=35,  Enderecos = new List<Endereco>(){ new Endereco{ Cidade="Suzano",Rua="Rua"} }},
                new Pessoa{Codigo=2,Nome="Abel",SobreNome="",Idade=25,  Enderecos = new List<Endereco>(){ new Endereco{ Cidade="Poa",Rua="Rua"} }},
                new Pessoa{Codigo=3,Nome="Caim",SobreNome="",Idade=45,  Enderecos = new List<Endereco>(){ new Endereco{ Cidade="Mogi",Rua="Rua"} }},
                new Pessoa{Codigo=4,Nome="Judas",SobreNome="",Idade=18,   Enderecos = new List<Endereco>(){ new Endereco{ Cidade="",Rua="Rua"} }}

            };
        }

        public static Pessoa Get(int codigo)
        {
            return Get().FirstOrDefault(p => p.Codigo == codigo);
        }

        
    }
}