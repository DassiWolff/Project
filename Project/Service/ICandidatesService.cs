using Microsoft.AspNetCore.Mvc;
using Project.Entities;

namespace Project.Service
{
    public interface ICandidatesService
    {
        Task<string> GetC();
        Task<IEnumerable<Candidates>> GetCandidates(int? Year, [FromQuery] int?[] Languages);
    }
}