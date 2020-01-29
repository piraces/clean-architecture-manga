namespace Spa.Controllers
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Registration Request.
    /// </summary>
    public sealed class RegisterRequest
    {
        /// <summary>
        /// Gets or sets sSN.
        /// </summary>
        [Required]
        public string SSN { get; set; }

        /// <summary>
        /// Gets or sets initial Amount.
        /// </summary>
        [Required]
        public decimal InitialAmount { get; set; }
    }
}