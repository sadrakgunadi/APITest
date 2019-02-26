using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Services.Protocols;
using TransferService.Models;

namespace TransferService.Controllers
{
    public class TransferController : ApiController
    {
        // POST: api/Transfer
        public IHttpActionResult Post([FromBody]Transfer transfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            transfer.strJSON = JsonConvert.SerializeObject(new
            {
                FromAccount = transfer.FromAccount,
                BeneName = transfer.BeneName,
                Amount = transfer.Amount,
                Description = transfer.Description,
                Product = transfer.Product,
                Address = transfer.Address
            }, Formatting.Indented).Trim();
            return Json(transfer);
        }
    }
}
