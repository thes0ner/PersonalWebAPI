using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebAPI.Application.Repositories;

namespace PersonalWebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        readonly private IProjectReadRepository _projectReadRepository;
        readonly private IProjectWriteRepository _projectWriteRepository;

        public ProjectsController(IProjectReadRepository projectReadRepository, IProjectWriteRepository projectWriteRepository)
        {
            _projectReadRepository = projectReadRepository;
            _projectWriteRepository = projectWriteRepository;
        }



        [HttpGet]
        public async Task Get()
        {
            //await _projectWriteRepository.AddRangeAsync(new()
            // {
            //     new(){Title = "Website 1",Description = "Hello is a beautyfull website. 1"},
            //     new(){Title = "Website 2",Description = "Hello is a beautyfull website. 2"},
            //     new(){Title = "Website 3",Description = "Hello is a beautyfull website. 3"},

            // });

            // await _projectWriteRepository.SaveAsync();

            var p = await _projectReadRepository.GetByIdAsync("4C4C87A1-2C50-45A6-7EE3-08DC7C731033",false);
            p.Title = "New Title";

            await _projectWriteRepository.SaveAsync();

        }
    }
}
