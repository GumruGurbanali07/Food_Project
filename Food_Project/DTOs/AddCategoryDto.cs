﻿using System.ComponentModel.DataAnnotations;

namespace Food_Project.DTOs
{
    public class AddCategoryDto
    {
        [Required(ErrorMessage = "Category name is required!")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Category description is required!")]
        public string CategoryDescription { get; set; }
    }
}
