using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        private readonly ICaseServices _caseService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseController"/> class.
        /// </summary>
        /// <param name="caseService">
        /// The case service.
        /// </param>
        public CaseController(ICaseServices caseService)
        {
            _caseService = caseService;
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CaseDto caseDto)
        {
            var (validation, result) = await _caseService.UpdateCase(caseDto);
            if (!validation.IsValid)
            {
                return this.BadRequest(validation.Errors);
            }

            return this.Ok(result);
        }
    }
}
