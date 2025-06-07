namespace ApiBicycleRental.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public string? AltText { get; set; }
        public int? BicycleId { get; set; } // Nullable to allow for no associated bicycle
        public virtual Bicicleta? Bicycle { get; set; } // Navigation property for related Bicycle entity
        public int? UserId { get; set; } // Nullable to allow for no associated user
        public virtual Usuario? User { get; set; } // Navigation property for related User entity
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Default to current UTC time
        public DateTime? UpdatedAt { get; set; } // Nullable to allow for no updates yet
        public DateTime? DeletedAt { get; set; } // Nullable to allow for no deletion yet
        public bool IsActive { get; set; } = true; // Indicates if the photo is active or not

    }
}
