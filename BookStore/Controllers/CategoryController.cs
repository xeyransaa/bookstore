using AutoMapper;
using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryManager _categoryManager;
        public CategoryController(IMapper mapper, ICategoryManager categoryManager)
        {
            _mapper = mapper;
            _categoryManager = categoryManager;
        }

        
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            JsonResult res = new(new {});
            var categories = await _categoryManager.GetAll();
            var categoriesMapper = _mapper.Map<List<CategoryDTO>>(categories);
            res.Value = new
            {
                status = 202,
                data = categoriesMapper
            };
            return res;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Category was not found"};
                return res;
            }
            var category = await _categoryManager.GetById(id.Value);
            var categoryMapper = _mapper.Map<CategoryDTO>(category);
            res.Value = new { status = 200, data = categoryMapper };
            return res;

        }

        // POST api/<CategoryController>
        [HttpPost("create")]
        public JsonResult Add(CategoryDTO category)
        {
            JsonResult res = new(new { });
            try
            {
                category.ParentCategoryId = category.ParentCategoryId == 0 ? null : category.ParentCategoryId;
                
                var _mapperCategory = _mapper.Map<CategoryDTO, Category>(category);
                _categoryManager.Add(_mapperCategory);
                res.Value = new { status = 201, message = "Category was created succesfully" };
                return res;
            }
            catch (Exception)
            {

                res.Value = new { status = 403, message = "Error" };
                return res;
            }

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int? id, CategoryDTO category)
        {
            JsonResult res = new(new { });
            try
            {
                category.ParentCategoryId=category.ParentCategoryId == 0 ?null: category.ParentCategoryId;
                var categoryMapper = _mapper.Map<Category>(category);
                _categoryManager.Update(id.Value, categoryMapper);
                res.Value = new {status=200, data = categoryMapper };
                return res;

            }
            catch (Exception)
            {
                res.Value= new { status =403, message="Error" };
                return res;
            }
            
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
