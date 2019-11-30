using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public string Uf { get; set; }

        public string Unidade { get; set; }

        public string Ibge { get; set; }

        public string Gia { get; set; }
    }
}
