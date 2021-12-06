using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2.Models
{
    public class Fornecedor
    {
        public long FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }
    }
}