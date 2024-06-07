using System.Runtime.Serialization;

namespace EdificioSoap.Entities
{
    [DataContract]
    public class EdificioEntity
    {
        [DataMember]
        public List<DepartamentoEntity> Departamentos { get; set; }
    }
}
