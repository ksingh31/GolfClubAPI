using GolfClub.API.Data;
using GolfClub.API.DTOs;
using GolfClub.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using GolfClubAPI.DTOs;

namespace GolfClub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reservationsController : ControllerBase
    {
        private readonly IAuthUserRepository _repo;
        private readonly IGolfRepository _golfrepo;
        private readonly IConfiguration _config;
        public reservationsController(IAuthUserRepository repo, IConfiguration config, IGolfRepository golfrepo)
        {
            _config = config;
            _repo = repo;
            _golfrepo = golfrepo;
        }

        [HttpPost("reserve")]
        public async Task<bool> AddReservation(reservationDTO resdata)
        {
            return await _golfrepo.AddReservation(resdata);
        }

        [HttpPost("approve")]
        public async Task<bool> ApproveReservation(approvalDTO approvalData)
        {
            return await _golfrepo.ApproveReservation(approvalData);
        }

        [HttpGet("getTeeTimes")]
        public async Task<IActionResult> GetTeeTimes() {
            var tee = await _golfrepo.GetTeeTimes();
            return Ok(tee);
        }

        [HttpDelete("deletereservation")]
        public async Task<bool> RemoveReservation(int id)
        {
            return await _golfrepo.RemoveReservation(id);
        }

        [HttpGet("getTeeTimesById")]
        public async Task<IActionResult> GetTeeTimesById(int id) {
            var tee = await _golfrepo.GetTeeTimesById(id);
            return Ok(tee);
        }
    }
}