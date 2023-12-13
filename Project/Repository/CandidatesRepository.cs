using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using System.Web.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace Project.Repository
{
    public class CandidatesRepository: ICandidatesRepository
    {

        //static List<Candidates> ListCandidates = new List<Candidates>();
        //public List<Candidates> GetPresents()
        //{
        //    if (ListCandidates.Count == 0)
        //    {
        //        ListCandidates.Add(new Candidates { Id= 1,Name= "Moshe",BeginYear= new DateTime(2020, 10, 1), LastUpdateDate= new DateTime(2022 - 11 - 03),Languages= new List<Languages> {} });

        //    }
        //    return ListCandidates;
        //}


        public async Task<string> GetC()
        {
            {
                string baseUrl = "https://raw.githubusercontent.com/ozsoftware/canidates/main/db.json";
                try
                {

                    var client = new HttpClient();
                    var response = await client.GetAsync(baseUrl);
                    var conect = await response.Content.ReadAsStringAsync();
                    
                    return conect;


                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception Hit------------");
                    Console.WriteLine(exception);
                    return null;
                }
            }
        }
        
            async Task<IEnumerable<Candidates>> GetCandidatesAsync(int? Year, [FromQuery] int?[] Languages)
        {
            string baseUrl = "https://raw.githubusercontent.com/ozsoftware/canidates/main/db.json";
            try
            {

                var client = new HttpClient();
                var response =  client.GetAsync(baseUrl);
                var conect = await response.Content.ReadAsStringAsync();
                var query = conect.Where(candidates =>
                    (Year == null ? (true) : (candidates.BeginYear.Contains(Year))))
               .OrderBy(candidates => candidates.Id);
             
                List<Candidates> products = await query.ToListAsync();
                return conect;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
                return null;
            }
           
        }

    }
}
