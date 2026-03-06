using Application.ViewModels.Partners.v1;
using AutoMapper;
using Domain;

namespace Application.Mappings;

public class PartnerMapping : Profile
{
    public PartnerMapping()
    {
        CreateMap<Partner, PartnerGetAllResponseViewModel>().ReverseMap();
    }
}