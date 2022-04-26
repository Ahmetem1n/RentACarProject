using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodGroupsController : ControllerBase
    {
        IBloodGroupService _bloodGroupService;
        public BloodGroupsController(IBloodGroupService bloodGroupService)
        {
            _bloodGroupService = bloodGroupService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _bloodGroupService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(long bloodGroupId)
        {
            var result = _bloodGroupService.GetById(bloodGroupId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }   

        [HttpPost("add")]
        public IActionResult Add(BloodGroup bloodGroup)
        {
            var result = _bloodGroupService.Add(bloodGroup);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(BloodGroup bloodGroup)
        {
            var result = _bloodGroupService.Update(bloodGroup);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(BloodGroup bloodGroup)
        {
            var result = _bloodGroupService.Delete(bloodGroup);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
