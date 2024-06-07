using EdificioService;
using EdificioSoap.Entities;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.ServiceModel;
using System.Xml.Linq;

namespace EdificioSoap.ServicesContracts
{
    [ServiceContract]
    public interface IEdificioService
    {
        [OperationContract]
        List<DepartamentoEntity> ObtenerDepartamentosDesocupados();
    }
    public class EdificioService : IEdificioService
    {
        private Edificio Edificio { get; set; }

        public EdificioService() { 
            Edificio = new Edificio();
        }

        public List<DepartamentoEntity> ObtenerDepartamentosDesocupados()
        {
            return Edificio.ObtenerDepartamentosDesocupados().Select(x => new DepartamentoEntity {
                NroDepartamento = x.NroDepartamento,
                ApellidoDueño = x.ApellidoDueño,
                NombreDueño = x.NombreDueño
            }).ToList();
        }
    }
}
