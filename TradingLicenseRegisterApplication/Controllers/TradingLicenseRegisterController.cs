using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TradingLicenseRegisterApplication.Models;

namespace TradingLicenseRegisterApplication.Controllers
{
    [Route("api/[controller]")]
    public class TradingLicenseRegisterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] TradingLicenseRegisterRequest request)
        {

            using (TradingLicenseDbContext context = new TradingLicenseDbContext())
            {
                int existingDB = (from mlc in context.Mlcs
                                  join ward in context.Wards
                                  on mlc.Mlccd equals ward.Mlccd
                                  where mlc.Mlccd.Equals(int.Parse(request.Constituency)) &&
                                  ward.Wardcd.Equals(int.Parse(request.Ward))
                                  select mlc).Count();
                if (existingDB == 0)
                    return new BadRequestObjectResult("Given MLC and Ward doesn't match");

                foreach (TradeClassification tradeClassification in request.TradeClassification)
                {
                    {
                        int tradeClassifications = (from major in context.Majors
                                                    join minor in context.Minors on major.Majorcd equals minor.Majorcd
                                                    join sb in context.Subs on minor.Minorcd equals sb.Minorcd
                                                    where major.Majorcd.Equals(int.Parse(tradeClassification.MajorTrade)) &&
                                                    minor.Minorcd.Equals(int.Parse(tradeClassification.MinorTrade)) &&
                                                    sb.Subcd.Equals(int.Parse(tradeClassification.SubTrade))
                                                    select major).Count();
                        if (tradeClassifications == 0)
                        {
                            string response = string.Format("Check Major trade=> {0}, minor trade=> {1} and sub trade => {2}", tradeClassification.MajorTrade, tradeClassification.MinorTrade, tradeClassification.SubTrade);
                            return new BadRequestObjectResult(response);
                        }

                    }
                }

                var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<TradingLicenseRegisterRequest, TradingLicenseRegisterResponse>());
                var mapper = new Mapper(config);
                var responseObj = mapper.Map<TradingLicenseRegisterResponse>(request);
                return Ok(responseObj);
            }
        }
    }
}