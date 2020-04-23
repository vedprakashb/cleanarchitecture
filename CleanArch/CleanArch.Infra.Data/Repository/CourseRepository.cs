using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;

namespace CleanArch.Infra.Data.Repository
{
    public  class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext ctx)
        {
            _context = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
