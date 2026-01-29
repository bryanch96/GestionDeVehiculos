using GestionDeVehiculos.Model;

namespace GestionDeVehiculos.DA
{
    public class VehiculoRepository
    {
        // Lista en memoria para simular la BD
        private static List<Vehiculo> _inventario = new List<Vehiculo>();

        public void Crear(Vehiculo v) => _inventario.Add(v);

        public List<Vehiculo> LeerTodo() => _inventario;

        public void Actualizar(Vehiculo v)
        {
            var index = _inventario.FindIndex(x => x.Id == v.Id);
            if (index != -1) _inventario[index] = v;
        }

        public void Eliminar(int id) => _inventario.RemoveAll(x => x.Id == id);
    }
}