using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualinea.Models
{
    public enum OkNok
    {
        Nok,
        Ok
    }
    public class RegistroLaudo
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public int IdInsumo { get; set; }
        public int IdFornecedor { get; set; }
        public int IdAnalista { get; set; }
        public OkNok ResultadoFinal { get; set; }
        public string? Observacoes { get; set; }
        public string? Lote { get; set; }
        public string? NotaFiscal { get; set; }
        public float? Brix { get; set; }
        public float? Particulas { get; set; }
        public float? Peso { get; set; }
        public float? Ph { get; set; }
        public float? Umidade { get; set; }
        public float? Viscosidade { get; set; }
        public float? Temperatura { get; set; }
        public OkNok? Solidificacao { get; set; }
        public OkNok? Textura { get; set; }
        public OkNok? Vedacao { get; set; }
        public OkNok? Medida { get; set; }
        public OkNok? Granulometria { get; set; }
        public OkNok? InspecaoVisual { get; set; }
        public OkNok? Dimensao { get; set; }
        public OkNok? Cor { get; set; }
        public OkNok? CorConcentrado { get; set; }
        public OkNok? CorDiluicao { get; set; }
        public OkNok? Odor { get; set; }
        public OkNok? OdorConcentrado { get; set; }
        public OkNok? OdorDiluicao { get; set; }
        public OkNok? Sabor { get; set; }
        public OkNok? SaborDiluicao { get; set; }
    }
}