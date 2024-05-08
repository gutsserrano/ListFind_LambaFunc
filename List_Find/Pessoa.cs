using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Find
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
