using AutoMapper;
using CadastroFamilia.DTOs;
using CadastroFamilia.Models;
using CadastroFamilia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFamilia.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<FormFamiliaViewModel, Familia>();
            Mapper.CreateMap<Familia, FormFamiliaViewModel>();

            // Dtos
            Mapper.CreateMap<Familia, FamiliaDto>();
            Mapper.CreateMap<FamiliaDto, Familia>();
            Mapper.CreateMap<Filho, FilhoDto>();
            Mapper.CreateMap<FilhoDto, Filho>();
            Mapper.CreateMap<Marido, MaridoDto>();
            Mapper.CreateMap<MaridoDto, Marido>();
            Mapper.CreateMap<Esposa, EsposaDto>();
            Mapper.CreateMap<EsposaDto, Esposa>();
        }
    }
}