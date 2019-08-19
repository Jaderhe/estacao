using System;
using System.Collections.Generic;

namespace estacaoAPI.Models
{
    public partial class Leitura
    {
        public int IdLeitura { get; set; }
        public DateTime Data { get; set; }
        public string Hash { get; set; }
        public decimal Veloc { get; set; }
        public decimal Umid { get; set; }
        public decimal Temp { get; set; }
    }
}
