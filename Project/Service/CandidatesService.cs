using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Entities;
using Project.Repository;

namespace Project.Service
{
    public class CandidatesService: ICandidatesService
    {
        ICandidatesRepository _candidatesRepository;
        public CandidatesService(ICandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }
        public async Task<string> GetC()
        {
            //string response = await _candidatesRepository.GetUsers();
            //List<string> users = response;
            return await _candidatesRepository.GetC();


        }
        public async Task<IEnumerable<Candidates>> GetCandidates(int? Year, [FromQuery] int?[] Languages)
        {
            return await _candidatesRepository.GetCandidatesAsync(Year, Languages);
        }

    }
}
