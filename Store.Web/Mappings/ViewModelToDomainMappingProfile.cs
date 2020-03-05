using AutoMapper;
using Store.Model.Models;
using Store.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public string ProfileName => "ViewModelToDomainMappings";

        protected override void Configure()
        {

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<GadgetFormViewModel, Gadget>()
            //          .ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
            //          .ForMember(g => g.Description, map => map.MapFrom(vm => vm.GadgetDescription))
            //          .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
            //          .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
            //          .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));


            //});
            //_userQueryConfig = config.CreateMapper();

            CreateMap<GadgetFormViewModel, Gadget>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.GadgetDescription))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));
        }
    }
}