using AutoMapper;
using Vega.Models;
using Vega.Controllers.Resources;

namespace Vega.Mapping
{
    public class MappingProfile: Profile
    {
       public MappingProfile()
       {
           CreateMap<Make, MakeResource>();
           CreateMap<Model, ModelResource>();
           CreateMap<Feature, FeatureResource>();
       }
    }
}