namespace EdificioService
{
    public class Edificio
    {
        public List<Departamento> Departamentos { get; set; }

        public Edificio() { 
            Departamentos = new List<Departamento>();
            Departamentos.Add(new Departamento()
            {
                NroDepartamento = 101,
                NombreDueño = "Gonzalo"
            });

            Departamentos.Add(new Departamento()
            {
                NroDepartamento = 102,
                NombreDueño = "Maxi"
            });

            Departamentos.Add(new Departamento()
            {
                NroDepartamento = 103
            });
        }

        public bool AgregarDepartamento(int nroDepartamento, string nombreDueño) { 
            Departamento departamento = new Departamento();
            departamento.NombreDueño = nombreDueño;
            departamento.NroDepartamento = nroDepartamento;

            Departamentos.Add(departamento);

            return true;
        }

        public List<Departamento> ObtenerDepartamentosDesocupados() {
            List<Departamento> departamentosFiltrados = Departamentos.FindAll(x => x.NombreDueño == null);

            return departamentosFiltrados;
        }

        public string ObtenerNombreDepartamento(int nroDepartamento) {
            Departamento departamento = Departamentos.FirstOrDefault(x => x.NroDepartamento == nroDepartamento);

            if (departamento== null)
            {
                return null;
            }

            return departamento.ObtenerNombreCompletoDueño();
        }
    }
}