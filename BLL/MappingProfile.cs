﻿using AutoMapper;
using BLL.Models;
using CL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<BooksDTO, Book>();
            CreateMap<Book, BooksDTO>();
        }
    }
}
