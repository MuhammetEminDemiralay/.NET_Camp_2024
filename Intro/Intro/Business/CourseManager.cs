using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concrete;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {
        // Dependency Injection
        private readonly ICourseDal _courseDal;

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            // Business ruless
            return _courseDal.GetAll();
        }
    }
}
