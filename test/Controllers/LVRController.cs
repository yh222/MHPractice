using Microsoft.AspNetCore.Mvc;

namespace MHPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LVRController : ControllerBase
    {

        public LVRController()
        {
        }

        [HttpGet(Name = "GetLVR")]
        public string Get(string propertyVal, string loanVal)
        {
            try
            {
                decimal pv = decimal.Parse(propertyVal.Replace("$", String.Empty));
                decimal lv = decimal.Parse(loanVal.Replace("$", String.Empty));

                return String.Format("{0:P2}", lv / pv);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }


    }
}