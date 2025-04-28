using TeamsApi.Dominio.Models;

namespace TeamsApi.Aplicacion.Interfaces.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<Team?> GetTeamByIdIncludeMembers(int id); 
    }
}
