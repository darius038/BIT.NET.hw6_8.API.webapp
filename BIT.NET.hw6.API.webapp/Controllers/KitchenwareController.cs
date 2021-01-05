using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIT.NET.hw6.API.webapp.Data;
using BIT.NET.hw6.API.webapp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIT.NET.hw6.API.webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitchenwareController : ShopController<Kitchenware>
    {
        public KitchenwareController(IShopService<Kitchenware> service) : base(service)
        {

        }
    }
}
