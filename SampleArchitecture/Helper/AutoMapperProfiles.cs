using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestArchitecture.Domain;
using TestArchitecture.DTO;

//using AspEComm.Dto;
//using AspEComm.Entity;
//using static AspEComm.Dto.CategoriesDTO;
//using static AspEComm.Dto.CommentsDTO;
//using static AspEComm.Dto.PicturesDTO;
//using static AspEComm.Dto.ProductsDTO;

namespace TestArchitecture.Web.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<City, CityForListDto>()
            //    .ForMember(dest => dest.PhotoUrl, opt =>
            //    {
            //        opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            //    });

            CreateMap<Student, StudentListDTO>().ForMember(dest=>dest.StudentId, opt =>
            {
                opt.MapFrom(src=>src.Id);
            });

            CreateMap<Teacher, TeacherList>().ForMember(dest => dest.TeacherId, opt =>
            {
                opt.MapFrom(src => src.Id);
            });



        }
    }
}
