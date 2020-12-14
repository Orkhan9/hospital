﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hospital.DAL.Entities;
using Microsoft.AspNetCore.Http;

namespace Hospital.BLL.DTO.Blog
{
    public class BlogCreateDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        
        public string Topic { get; set; }
        [Required]
        
        public string Description { get; set; }
        [Required]
        
        public IFormFile Photo { get; set; }
        [Required]
        public DateTime PublishTime { get; set; }

        public BlogCreateDto()
        {
            PublishTime=DateTime.Now;
        }

    }
}