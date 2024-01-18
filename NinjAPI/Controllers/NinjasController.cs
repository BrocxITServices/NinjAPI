﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NinjAPI.Data;
using NinjAPI.Models;

namespace NinjAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinjasController : ControllerBase
    {
        private readonly GymContext _context;

        public NinjasController(GymContext context)
        {
            _context = context;
        }
        [HttpGet(Name = "GetNinja")]
        // GET: Ninjas
        public IActionResult Index()
        {
            return Ok(); //TODO GetNinjas from db
        }

        //TODO create new ninja 
        [HttpPost(Name = "NinjaCreate")]
        public IActionResult Post()
        {
            var ninja = new Ninja();
            ninja.Name = "Jeffrey";
            ninja.DateOfBirth = new DateOnly(2000, 2, 12);
            ninja.Specialization = 0;
            ninja.Role = "Trainer";
            _context.Ninjas.Add(ninja);
            _context.SaveChanges();
            return Ok();
        }

    }
}