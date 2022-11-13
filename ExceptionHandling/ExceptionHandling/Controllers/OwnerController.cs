using System;
using ExceptionHandling.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ExceptionHandling.Services;

namespace ExceptionHandling.Controllers
{
	
        //[ValidateModelState]  
        [Route("api/[controller]")]
        [ApiController]
        public class OwnerController : ControllerBase
        {
            private readonly IOwnerServices _ownerServices;

            public OwnerController(IOwnerServices ownerServices)
            {
                _ownerServices = ownerServices;
            }

            [HttpPost("Create")]
            public IActionResult Post()
            {
                var result = _ownerServices.Add();
                return Ok(result);
            }
            [HttpGet("GetOwner")]
            public IActionResult Get()
            {
                var result = _ownerServices.Get();
                return Ok(result);
            }

            [HttpDelete("DeleteOwner")]
            public IActionResult Delete()
        {
               

                return BadRequest("It is not allowed");
            }

       


        /// <summary>
        /// Reflection ile classların tüm propertilerini ekrana bastık
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetOwnerProperties")]
            public IActionResult GetOwnerProperties()
            {
                Owner owner = new Owner();
                var result = new List<string>();
            var properties = owner.GetType().GetProperties().ToString();
                foreach (var item in properties)
                {
                    result.Add(item.ToString());
                }
                return Ok(result);
            }
        }
    }


