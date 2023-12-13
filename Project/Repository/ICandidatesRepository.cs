using Microsoft.AspNetCore.Mvc;
using Project.Entities;

namespace Project.Repository
{
    public interface ICandidatesRepository
    {
        Task<string> GetC();
        Task<IEnumerable<Candidates>> GetCandidatesAsync(int? Year, [FromQuery] int?[] Languages);
    }
}