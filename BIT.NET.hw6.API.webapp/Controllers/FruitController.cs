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
    public class FruitController : ShopController<Fruit>
    {
        public FruitController(IShopService<Fruit> service) : base(service)
        {

        }
    }
}
