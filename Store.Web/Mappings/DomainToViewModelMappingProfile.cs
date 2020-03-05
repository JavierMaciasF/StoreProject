using AutoMapper;
using Store.Model.Models;
using Store.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public string ProfileName => "DomainToViewModelMappings";

        protected override void Configure()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Gadget, GadgetViewModel>();
        }
    }
}