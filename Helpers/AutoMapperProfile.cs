using AutoMapper;
using core8_ember_oracle.Entities;
using core8_ember_oracle.Models.dto;

namespace core8_ember_oracle.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserRegister, User>();
            CreateMap<UserLogin, User>();
            CreateMap<UserUpdate, User>();
            CreateMap<UserPasswordUpdate, User>();
            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>();

        }
    }
    

}