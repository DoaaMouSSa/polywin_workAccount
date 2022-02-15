﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloyWinDto.Dto
{
    public class DtoDataSheets
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } 
        public IFormFile fileUpload { get; set; }
    }
}
