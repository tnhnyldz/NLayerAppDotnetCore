﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.CoreLayer.DTOs
{
    public class CategoryWithProductsDTO : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
