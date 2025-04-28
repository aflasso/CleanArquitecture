using AutoMapper;
using FluentValidation;
using TeamsApi.Aplicacion.Dtos;
using TeamsApi.Aplicacion.Mapping;
using TeamsApi.Aplicacion.Services;
using TeamsApi.Aplicacion.Validations;
using TeamsApi.Aplicacion.Interfaces.Repositories;
using TeamsApi.Infraestructura.Repositories;
using TeamsApi.Aplicacion.Interfaces.Services;

namespace TeamsApi.Api.Extensions;

public static class ModulesExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ITeamRepository, TeamsRepository>();
        services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();

        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITeamService, TeamService>();
        services.AddScoped<ITeamMemberService, TeamMemberService>();

        return services;
    }

    public static IServiceCollection AddMapping(this IServiceCollection services)
    {

        // Auto Mapper Configurations
         var mapperConfig = new MapperConfiguration(mc =>
         {
             mc.AddProfile(new MappingProfile());
         });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);

        return services;
    }

    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<TeamDto>, TeamValidator>();
        services.AddScoped<IValidator<TeamMemberDto>, TeamMemberValidator>();

        return services;
    }
}
