using System;

namespace _004_TresCamadas_MVC
{
    class Program
    {
        static void Main()
        {
            var cp = new Controller.Pessoa();

            var mp = cp.Get("AGNALDO", "abc123@");

            if (mp == null) return;

            Console.WriteLine("{0} -> {1}", mp.Codigo, mp.Nome);

            Console.ReadKey();
        }
    }
}

namespace Model
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }
}


namespace Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        public Model.Pessoa Get(String u, String p)
        {
            return u.Equals("AGNALDO") && p.Equals("abc123@")
                ? new Model.Pessoa() { Codigo = 1, Nome = "ADÃO" }
                : null;
        }
    }
}