﻿using Business.Abstract;
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
    public class PhoneNumbersController : ControllerBase
    {
        IPhoneNumberService _phoneNumberService;
        public PhoneNumbersController(IPhoneNumberService phoneNumberService)
        {
            _phoneNumberService = phoneNumberService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _phoneNumberService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int phoneId)
        {
            var result = _phoneNumberService.GetById(phoneId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }   

        [HttpPost("add")]
        public IActionResult Add(PhoneNumber phoneNumber)
        {
            var result = _phoneNumberService.Add(phoneNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(PhoneNumber phoneNumber)
        {
            var result = _phoneNumberService.Update(phoneNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PhoneNumber phoneNumber)
        {
            var result = _phoneNumberService.Delete(phoneNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}