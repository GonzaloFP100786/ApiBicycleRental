namespace ApiBicycleRental.Models
{
    public class Devolucion
    {
        public int Id { get; set; }
        public DateTime FechaDevolucion { get; set; } = DateTime.Now;
        public DateTime HoraDevolucion { get; set; } = DateTime.Now;
        public TimeSpan Duracion { get; set; } // Duración de la devolución
        public int prestamoId { get; set; } // ID del préstamo asociado a la devolución
        public Prestamo Prestamo { get; set; } // Relación con Prestamo
        public int clienteId { get; set; } // ID del cliente que realiza la devolución
        public Cliente Cliente { get; set; } // Relación con Cliente

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } // Relación con Usuario
        public decimal Precio { get; set; } // Precio de la devolución
        
        public decimal Penalizacion { get; set; } // Penalización por devolución tardía
        public decimal Total { get; set; } // Total a pagar por la devolución (Precio + Penalización)
        public string Observaciones { get; set; } // Observaciones sobre la devolución
        public string Estado { get; set; } // Estado de la devolución (ej. "Pendiente", "Completada")
    }
}
