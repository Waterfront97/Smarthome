﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SmartServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TemperatureController : ControllerBase
  {

    public TemperatureController()
    {
    }

    [HttpGet]
    public string Get()
    {
      return "";
    }

  }
}