using TeamsApi.Dominio.Models;

namespace TeamsApi.Aplicacion.Interfaces.Services;

public interface ITeamMemberService
{
    Task<TeamMember> CreateTeamMember(TeamMember teamMember);

    Task DeleteTeamMember(int id);

    Task<List<TeamMember>> GetAllTeamMembers();

    Task<TeamMember> GetTeamMemberById(int id);

    Task<TeamMember> UpdateTeamMember(int id, TeamMember teamMember);

}
