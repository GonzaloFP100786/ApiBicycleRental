namespace ApiBicycleRental.Models
{
    public class Bicicleta
    {
        public int Id { get; set; }
        public string Marca { get; set; } // Marca de la bicicleta
        public string Modelo { get; set; } // Modelo de la bicicleta
        public string Color { get; set; } // Color de la bicicleta
        public string Tipo { get; set; } // Tipo de bicicleta (ej. montaña, carretera, híbrida)
        public bool Disponible { get; set; } = true; // Indica si la bicicleta está disponible para préstamo        
        public DateTime FechaRegistro { get; set; } = DateTime.Now; // Fecha en que se registró la bicicleta
        public DateTime FechaUltimoMantenimiento { get; set; } = DateTime.Now; // Fecha del último mantenimiento
        public string Observaciones { get; set; } // Observaciones sobre la bicicleta (ej. daños, reparaciones)
        public DateTime Observaciono { get; set; } = DateTime.Now; // Fecha de la última observación
        public string Estado { get; set; } // Estado de la bicicleta (ej. "Disponible", "En préstamo", "En mantenimiento")
        
    }
}
