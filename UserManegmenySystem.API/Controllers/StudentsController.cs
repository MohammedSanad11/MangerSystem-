using Azure;
using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using NuGet.Protocol.Core.Types;
using Repositorylayer;
using Servicelayer;


namespace UserManegmenySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRrepositry<Student> _irepositry;
        private readonly MangementSystemDbContext _applicationDbContext;
        public StudentsController(IRrepositry<Student> Irepositry, MangementSystemDbContext applicationDbContext)
        {
            _irepositry = Irepositry;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(nameof(GetStudentById))]
        public IActionResult GetStudentById(int Id)
        {
           
            try
            {
                var obj = _irepositry.Get(Id);
                if (obj == null)
                {
                    return NotFound(obj);
                }

                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                var erorr = new CoustomEroer<Student>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = new Student()
                }; 

            }
            return BadRequest();
        }
        [HttpGet(nameof(GetAllStudent))]
        public IActionResult GetAllStudent()
        {

            try
            {
                var obj = _irepositry.GetAll().ToList();
                if (obj == null)
                {
                    return NotFound(obj);
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {

                var erorr = new CoustomEroer<List<Student>>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = new List<Student>()
                };
            }

            return BadRequest();
        }
        [HttpPost(nameof(CreateStudent))]
        public IActionResult CreateStudent(Student stidentmodel)
        {
            try
            {

                if (stidentmodel != null)
                {
                    _irepositry.Insert(stidentmodel);
                    return Ok("Created Successfully");
                }
                else
                {
                    return BadRequest("Somethingwent wrong");
                }
            }

            catch 
            {
                var erorr = new CoustomEroer<Student>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = stidentmodel
                };

            }
            return BadRequest();
        }
        [HttpPost(nameof(UpdateStudent))]
        public IActionResult UpdateStudent(Student stidentmodel)
        {
            if (stidentmodel != null)
            {
                var erorr = new CoustomEroer<Student>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = stidentmodel
                };


                _irepositry.Update(stidentmodel);
                return Ok("Updated SuccessFully");
            }
            else
            {
                var erorr = new CoustomEroer<Student>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = stidentmodel
                };

                return BadRequest(erorr);
            }
        }
        [HttpDelete(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(Student stidentmodel)
        {
            try
            {
                if (stidentmodel != null)
                {
                    var erorr = new CoustomEroer<Student>
                    {
                        Code = "500",
                        Message = "Exption: Null Exption",
                        Result = stidentmodel
                    };

                    _irepositry.Delete(stidentmodel);
                    return Ok("Deleted Successfully");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {

                var erorr = new CoustomEroer<Student>
                {
                    Code = "500",
                    Message = "Exption: Null Exption",
                    Result = stidentmodel
                };
            }
            return BadRequest();
        }

    }
}

   
