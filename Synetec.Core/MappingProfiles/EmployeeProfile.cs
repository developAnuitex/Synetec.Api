using AutoMapper;
using Synetec.Core.Models;
using Synetec.DataAccess.Entities;

namespace Synetec.Core.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }
    }
}
