﻿using System.ComponentModel.DataAnnotations;

namespace DesignPatternsAsp.Models.ViewModels
{
    public class FormBeerVM
    {
        [Required]
        [Display(Name="Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Estilo")]
        public String Style { get; set; }
        [Display(Name = "Marca")]
        public Guid? BrandId { get; set; }
        [Display(Name="Otra Marca")]
        public string? OtherBrand { get; set; }
    }
}
