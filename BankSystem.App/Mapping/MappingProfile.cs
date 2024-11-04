using AutoMapper;
using BankSystem.Appl.DTOs;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Client, ClientDto>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Name} {src.Surname}"));
      
        CreateMap<ClientDto, Client>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => GetName(src.FullName, 0)))
            .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => GetName(src.FullName, 1)));

        CreateMap<Employee, EmployeeDto>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Name} {src.Surname}"));

        CreateMap<EmployeeDto, Employee>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => GetName(src.FullName, 0)))
            .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => GetName(src.FullName, 1)));
    }

    private string GetName(string fullName, int index)
    {
        var names = fullName.Split(' ');
        if (index >= 0 && index < names.Length)
        {
            return names[index];
        }

        return fullName;
    }
}