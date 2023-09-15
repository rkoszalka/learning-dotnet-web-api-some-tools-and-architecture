﻿using koszalka_api.Model;
using koszalka_api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace koszalka_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikeController : Controller
    {
        private readonly IBikeRepository _bikeRepository;

        public BikeController(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Response> CreateBike(Bike bike)
        {
            var rowsCreated = await _bikeRepository.Create(bike);
            if (rowsCreated.Equals(1))
            {
                Response successResponse =  new Response();
                successResponse.Message = "Created";
                successResponse.Status = "200";
                return successResponse;
            };

            Response errorResponse = new Response();
            errorResponse.Message = "Error";
            errorResponse.Status = "500";
            return errorResponse;
        }
    }
}