using Microsoft.AspNetCore.Mvc;
using Student2WithCQRS.Application.Commands._AssessmentCategory.Create;
using Student2WithCQRS.Application.Commands._AssessmentCategory.Delete;
using Student2WithCQRS.Application.Commands._AssessmentCategory.Update;
using Student2WithCQRS.Domain.Interface._AssessmentCategory;

namespace Student2WithCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_Controller : ApiController
    {
        private readonly ICategory _category;

        public Category_Controller(ICategory category)
        {
            _category = category;
        }
        [HttpGet]

        public IActionResult GetAllCategory()
        {
            var category = _category.GetAllCategory();

            return Ok(category);
        }

        [HttpGet("Id")]

        public IActionResult GetCategoriesById(int id)
        {
            var category = _category.GetCategoryById(id);

            if (category == null)
            {
                return BadRequest();
            }

            return Ok(category);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCategoryCommand command)
        {
            var createCategory = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetCategoriesById), new { id = createCategory.CategoryId }, createCategory);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, UpdateCategoryCommand command)
        {
            if (id == command.CategoryId) { return BadRequest(); }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteCategoryCommand { CategoryId = id });
            return NoContent();
        }
    }
}
