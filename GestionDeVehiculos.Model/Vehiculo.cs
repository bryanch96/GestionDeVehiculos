namespace GestionDeVehiculos.Model
{

    public enum MarcaVehiculo
    {
        Tesla = 1,
        Toyota = 2,
        BY  D = 3
    }
    public class Vehiculo
    {
        public int Id { get; set; }
        public MarcaVehiculo Marca { get; set; }
        public int Año { get; set; }
        public string Modelo { get; set; }
        public bool DobleTraccion { get; set; }

    }
}
