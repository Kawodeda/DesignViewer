using DesignViewer.Server.Controllers.Requests;
using DesignViewer.Server.Dtos;
using DesignViewer.Server.Exceptions;
using DesignViewer.Server.Filters;
using DesignViewer.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignViewer.Server.Controllers
{
    [ApiController]
    [Route("api/storage/v1/[controller]")]
    [TypeFilter(typeof(DefaultExceptionFilter))]
    public sealed class AssetsController : ControllerBase
    {
        private readonly IAssetStorageService _assetStorageService;

        public AssetsController(IAssetStorageService assetStorageService)
        {
            _assetStorageService = assetStorageService;
        }

        [HttpGet("images", Name = nameof(ListImages))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AssetDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<AssetDto>> ListImages()
        {
            return Ok(_assetStorageService.ListImages());
        }

        [HttpGet("mockups", Name = nameof(ListMockups))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AssetDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<AssetDto>> ListMockups()
        {
            return Ok(_assetStorageService.ListMockups());
        }

        [HttpGet("{storageId}/info", Name = nameof(GetAssetInfo))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AssetDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AssetDto> GetAssetInfo([FromRoute] string storageId)
        {
            try
            {
                return Ok(_assetStorageService.GetAssetInfo(storageId));
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto()
                {
                    Name = storageId
                });
            }
        }

        [HttpGet("{storageId}/content", Name = nameof(GetAssetContnet))]
        [Produces(contentType: "application/octet-stream", "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FileStreamResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetAssetContnet([FromRoute] string storageId)
        {
            try
            {
                Stream content = _assetStorageService.GetAssetContent(storageId);

                return File(content, "application/octet-stream");
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto()
                {
                    Name = storageId
                });
            }
        }

        [HttpPost(Name = nameof(UploadAsset))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(UploadAssetRequest))]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AssetDto))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AssetDto> UploadAsset([FromForm] UploadAssetRequest asset)
        {
            if (asset.Content == null || asset.Info == null)
            {
                return BadRequest(asset);
            }

            try
            {
                using Stream contentStream = asset.Content.OpenReadStream();
                AssetDto info = _assetStorageService.UploadAsset(contentStream, asset.Info);

                return CreatedAtAction(nameof(UploadAsset), info);
            }
            catch (FileAlreadyExistException)
            {
                return Conflict(new FileErrorDto()
                {
                    Name = asset.Info.StorageId
                });
            }
        }

        [HttpPut("{storageId}", Name = nameof(UpdateAsset))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AssetDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AssetDto> UpdateAsset([FromRoute] string storageId, IFormFile content)
        {
            try
            {
                using Stream contentStream = content.OpenReadStream();
                AssetDto info = _assetStorageService.UpdateAsset(storageId, contentStream);

                return Ok(info);
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto()
                {
                    Name = storageId
                });
            }
        }

        [HttpDelete("{storageId}", Name = nameof(DeleteAsset))]
        [Produces(contentType: "application/json")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(FileErrorDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteAsset([FromRoute] string storageId)
        {
            try
            {
                _assetStorageService.DeleteAsset(storageId);

                return NoContent();
            }
            catch (FileNotFoundException)
            {
                return NotFound(new FileErrorDto()
                {
                    Name = storageId
                });
            }
        }
    }
}
