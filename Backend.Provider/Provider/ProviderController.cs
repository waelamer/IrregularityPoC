using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DealStoreweb.Backend.Provider
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private string serviceName = "DealStoreWeb.Backend.Provider";
        private readonly IProviderAPI _providerAPI;

        public ProviderController(IProviderAPI providerAPI)
        {
            this._providerAPI = providerAPI;
        }


        /*
        API/Provider/{id} =>Detail by ID
        API/Provider/=>ALL
        API/Provider/Search
                 
        API/Provider/Start
        API/Provider/Stop
         
         */
        [HttpGet("Islive")]
        public bool IsLive()
        {
            var MyActivitySource = new ActivitySource(serviceName);
            using var activity = MyActivitySource.StartActivity("IsLive");
            activity?.SetTag("IsLive", "true");
            return true;
        }


        [HttpGet("all")]
        public async Task<IActionResult> All()
        {
            var result = await _providerAPI.GetAll();
            if (result.IsSuccess)
            {
                
                
                return Ok(result.Providers);
            }
            return NotFound();
        }
        [HttpPost("search")]
        public async Task<IActionResult> Search([FromBody] SearchParam search)
        {
            var result = await _providerAPI.Search(search);
            if (result.IsSuccess)
            {


                return Ok(result.Providers);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDealAsync(int id)
        {
            var result = await _providerAPI.GetDetails(id);
            if (result.IsSuccess)
            {
                

                return Ok(result.Item2);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProvider(Provider provider)
        {
            var result = await _providerAPI.ADD(provider);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateProvider(Provider provider)
        {
            var result = await _providerAPI.Update(provider);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteProvider(int id)
        {
            var result = await _providerAPI.Delete(id);
            if (result.IsSuccess)
            {
                return Ok(result.Item2);
            }
            return NotFound();
        }
    }

    public class SearchParam
    {
        public SearchParam()
        {
            Search_Text = "";
            Search_Regions = new string[0];
            Search_Category = new int[0];
        }
        //Search_Text:this.Txt_Search,
        //Search_Regions:this.Sel_Region,
        //Search_Category:this.Sel_Category
        public string Search_Text { get; set; }
        public string[] Search_Regions { get; set; }
        public int[] Search_Category { get; set; }
    }
}
