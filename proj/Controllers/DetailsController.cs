using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using proj.Models;
using proj.Data;
using AutoMapper;
using proj.Dtos;

namespace proj.Controllers
{
    [Route("api/Details")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private  readonly IProjRepo _repository;
        private readonly IMapper _mapper;

        public DetailsController(IProjRepo repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Detail>> GetAllDetails()
        {
            var DetailItems=_repository.GetAllDetails();
            return Ok(DetailItems);
        }


        [HttpGet("{id}")]
        public ActionResult <DetailReadDto> GetDetailById(int id)
        {
            var DetailItem=  _repository.GetDetailById(id);
            if(DetailItem!=null)
            {
                return Ok(_mapper.Map<DetailReadDto>(DetailItem));
            }
            return NotFound();
        }
    }
}