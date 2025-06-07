namespace ApiBicycleRental.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;
        public DateTime HoraPrestamo { get; set; } = DateTime.Now;
        public DateTime FechaDevolucion { get; set; } = DateTime.Now;
        public DateTime HoraDevolucion { get; set; } = DateTime.Now;
        public TimeSpan Duracion { get; set; } // Duración del préstamo
        public decimal PrecioPorHora { get; set; } // Precio por hora de alquiler
        public int BicicletaId { get; set; }
        public Bicicleta Bicicleta { get; set; } // Relación con Bicicleta
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } // Relación con Usuario
        public int clienteId { get; set; } // ID del cliente que realiza el préstamo
        public Cliente Cliente { get; set; } // Relación con Cliente
        public decimal Precio { get; set; } // Precio del préstamo
        public string Estado { get; set; } // Estado del préstamo (ej. "Activo", "Finalizado")
    }
}
