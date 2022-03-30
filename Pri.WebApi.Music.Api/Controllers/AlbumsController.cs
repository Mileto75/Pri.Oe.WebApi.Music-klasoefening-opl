using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using Pri.Oe.WebApi.Music.Core.Entities;
using Pri.Oe.WebApi.Music.Core.Repositories.Interfaces;
using Pri.WebApi.Music.Core.Interfaces.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        private readonly IMapper _mapper;
        
        public AlbumsController(IAlbumService albumService, IMapper mapper)
        {
            _albumService = albumService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _albumService.GetAllAsync();
            if(!result.IsSuccess)
            {
                return BadRequest(result.Error);
            }
            var albumsResponseDto = result.Items.Select(
                r => _mapper.Map<AlbumResponseDto>(r)).ToList();
           
                
            return Ok(albumsResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _albumService.GetByIdAsync(id);
            if(result.IsSuccess == false)
            {
                return BadRequest(result.Error);
            }
            AlbumResponseDto albumResponseDto
                = _mapper.Map<AlbumResponseDto>(result.Items.First());
            return Ok(albumResponseDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]AlbumRequestDto albumRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            //call service method
            if(await _albumService.AddAsync(albumRequestDto.Name,albumRequestDto.ReleaseDate,
                albumRequestDto.Image,albumRequestDto.ArtistId))
            {
                return Ok("Album addedd!");
            }
            return BadRequest("Album not added! Try again!");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm]AlbumUpdateRequestDto albumUpdateRequestDto)
        {
            var result = await _albumService.UpdateAsync(albumUpdateRequestDto.Id, albumUpdateRequestDto.Name, albumUpdateRequestDto.ReleaseDate,
                albumUpdateRequestDto.Image, albumUpdateRequestDto.ArtistId);
            if(!result)
            {
                return BadRequest("Product not updated! Please try again!");
            }
            return Ok("Product updated!");
        }
    }
}
