using StudentSubjectMarks.Models;
using System.Linq;
using System.Web.Http;

namespace StudentSubjectMarks.Controllers
{
    [RoutePrefix("api/marks")]
    public class MarksController : ApiController
    {
        private readonly AppDbContext _context = new AppDbContext();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetMark(int studentId, int subjectId)
        {
            var mark = _context.Marks.SingleOrDefault(m => m.StudentId == studentId && m.SubjectId == subjectId);

            if (mark == null)
            {
                return NotFound();
            }

            return Ok(mark);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult AddMark(Marks mark)
        {
            _context.Marks.Add(mark);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mark.Id }, mark);
        }
    }
}
