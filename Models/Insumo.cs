using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualinea.Models
{
    public class Insumo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Grupo { get; set; }
        public EmbMp Tipo { get; set; }
    }

    public enum EmbMp {
        Embalagem,
        MP
    }
}