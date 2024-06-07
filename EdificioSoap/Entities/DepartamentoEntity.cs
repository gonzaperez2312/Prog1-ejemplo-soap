using System.Runtime.Serialization;

namespace EdificioSoap.Entities
{
    [DataContract]
    public class DepartamentoEntity
    {
        [DataMember]
        public int NroDepartamento { get; set; }
        [DataMember]
        public string NombreDueño { get; set; }
        [DataMember]
        public string ApellidoDueño { get; set; }
    }
}
