using System;
using System.Collections.Generic;
using System.Linq;
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
        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
