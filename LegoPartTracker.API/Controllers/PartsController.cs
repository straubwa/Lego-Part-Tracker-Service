﻿using AutoMapper;
using LegoPartTracker.API.Models;
using LegoPartTracker.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegoPartTracker.API.Controllers
{
    [Route("api/parts")]
    public class PartsController : Controller
    {
        private ILogger<SetsController> _logger;
        private ISetInfoRepository _setInfoRepository;

        public PartsController(ILogger<SetsController> logger, ISetInfoRepository setInfoRepository)
        {
            _logger = logger;
            _setInfoRepository = setInfoRepository;
        }

        [HttpGet("PartsWithoutGroup/Categories")]
        public IActionResult GetCategoriessWithoutAssignedGroup()
        {
            var partsWithoutGroup = _setInfoRepository.GetPartGroupDetailsWithoutGroup();

            var a = partsWithoutGroup
                .GroupBy(g => new { g.CategoryId, g.CategoryName })
                .Select(g => new { Id = g.Key.CategoryId, Name = g.Key.CategoryName, PartCount = g.Count() });

            return Ok(a);
        }

        [HttpGet("PartsWithoutGroup/{categoryId}")]
        public IActionResult GetPartsWithoutGroup(int categoryId)
        {
            var parts = _setInfoRepository.GetPartGroupDetailsWithoutGroup(categoryId).OrderBy(o => o.Name);
            return Ok(parts);
        }


        [HttpGet("Groups")]
        public IActionResult GetGroups()
        {
            var groups = _setInfoRepository.GetGroups();

            return Ok(groups);
        }
    }
}
