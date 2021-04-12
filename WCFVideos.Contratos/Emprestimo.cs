using System.Runtime.Serialization;

namespace WCFVideos.Contratos
{
    [DataContract]
    public class Emprestimo
    {
        [DataMember]
        public decimal Valor { get; set; }
        [DataMember]
        public int QuantidadeDeParcelas { get; set; }
        [DataMember]
        public decimal TaxaDeJuros { get; set; }
    }
}
