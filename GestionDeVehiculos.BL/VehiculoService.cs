using GestionDeVehiculos.DA;
using GestionDeVehiculos.Model;

namespace GestionDeVehiculos.BL
{
    public class VehiculoService
    {
        private readonly VehiculoRepository _repository = new VehiculoRepository();

        public void AgregarVehiculo(Vehiculo v) => _repository.Crear(v);
        public List<Vehiculo> ObtenerInventario() => _repository.LeerTodo();
        public void EditarVehiculo(Vehiculo v) => _repository.Actualizar(v);
        public void BorrarVehiculo(int id) => _repository.Eliminar(id);
    }
}