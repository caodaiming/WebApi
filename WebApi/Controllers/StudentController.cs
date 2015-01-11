using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.ModelBinding;
using WebApi.Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// 用户接口
    /// </summary>
    public class StudentController : ApiController
    {
        /// <summary>
        /// 得到所有的学生信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StudentModel> Get()
        {
            return new List<StudentModel>();
        }

        /// <summary>
        /// 根据学生编号得到学生信息
        /// </summary>
        /// <param name="Id">学生编号</param>
        /// <returns></returns>
        public StudentModel Get(int Id)
        {
            return new StudentModel { };
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="studentModel">学生实体</param>
        /// <remarks>添加一个新的学生</remarks>
        /// <response code="400">Bad request </response>
        /// <response code="500">Internal Server Error</response>
        public void Post(StudentModel studentModel)
        {
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="Id">学生编号</param>
        /// <param name="studentModel">学生实体</param>
       
        [ResponseType(typeof(StudentModel))]
        [ActionName("UpdateStudentById")]
        public void Put(int Id, [Form]string studentModel)
        {

        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="Id">学生编号</param>
        public void Delete(int Id)
        {
        }

        /// <summary>
        /// 根据学生姓名得到学生信息
        /// </summary>
        /// <param name="name">学生姓名</param>
        /// <remarks>dfsafdsa</remarks>
        /// <returns></returns>
        //[Route(Name = "GetStudentByUserName")]
        //[ResponseType(typeof(StudentModel))]
        [HttpGet]
        [ActionName("GetStudentByUserName")]
        public IEnumerable<StudentModel> GetStudentByName(string name)
        {
            return new List<StudentModel>();
        }
    }
}
