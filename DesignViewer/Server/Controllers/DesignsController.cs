using BlazorViewer.Server.Dtos;
using BlazorViewer.Server.Exceptions;
using BlazorViewer.Server.Filters;
using BlazorViewer.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorViewer.Server.Controllers
{
    [ApiController]
    [Route("api/storage/v1/[controller]")]
    [TypeFilter(typeof(DesignsExceptionFilter))]
    public sealed class DesignsController : ControllerBase
    {
        private readonly IDesignStorageService _storageService;

        public DesignsController(IDesignStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("{name}/info", Name = nameof(GetDesignInfo))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DesignDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DesignDto> GetDesignInfo([FromRoute] string name)
        {
            try
            {
                DesignDto result = _storageService.GetDesignInfo(name);
                return Ok(result);
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto
                {
                    Name = name
                });
            }
        }

        [HttpGet("{name}/content", Name = nameof(GetDesignContent))]
        [Produces(contentType: "application/octet-stream", "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FileStreamResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetDesignContent([FromRoute] string name)
        {           
            try
            {
                Stream result = _storageService.GetDesignContent(name);
                return File(result, "application/octet-stream");
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto
                { 
                    Name = name
                });
            }
        }

        [HttpGet(Name = nameof(ListDesigns))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DesignDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<DesignDto>> ListDesigns()
        {
            var designs = _storageService.ListDesigns();
            return Ok(designs);
        }

        [HttpPost(Name = nameof(UploadDesignAutoName))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(DesignDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DesignDto> UploadDesignAutoName(IFormFile file)
        {
            Stream stream = file.OpenReadStream();
            DesignDto info = _storageService.UploadDesign(stream);

            return CreatedAtAction(nameof(UploadDesignAutoName), info);
        }

        [HttpPost("{name}", Name = nameof(UploadDesign))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(DesignDto))]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DesignDto> UploadDesign([FromRoute] string name, IFormFile file)
        {
            try
            {
                Stream stream = file.OpenReadStream();
                DesignDto info = _storageService.UploadDesign(stream, name);

                return CreatedAtAction(nameof(UploadDesign), info);
            }
            catch(FileAlreadyExistException)
            {
                return Conflict(new FileErrorDto
                {
                    Name = name
                });
            }
        }

        [HttpPut("{name}", Name = nameof(UpdateDesign))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DesignDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDesign([FromRoute] string name, IFormFile file)
        {
            Stream stream = file.OpenReadStream();
            DesignDto info = _storageService.UpdateDesign(name, stream);

            return Ok(info);
        }

        [HttpDelete("{name}", Name = nameof(DeleteDesign))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteDesign([FromRoute] string name)
        {
            try
            {
                _storageService.DeleteDesign(name);

                return NoContent();
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto
                {
                    Name = name
                });
            }
        }
    }
}
