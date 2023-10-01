using ArtAndTechnicalEducationInstitute.Data;
using ArtAndTechnicalEducationInstitute.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArtAndTechnicalEducationInstitute.Controllers
{
    public class StudentsRegisterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentsRegisterController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<StudentsRegister> objStudentsList = _db.Students.ToList();
            return View(objStudentsList);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(StudentsRegister obj)
        {
            if (ModelState.IsValid)
            { 
                _db.Students.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Student registered syccessfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();

            }

            StudentsRegister studentsRegisterFromDb = _db.Students.Find(id);
            if(studentsRegisterFromDb == null)
            {
                return NotFound();
            }

            return View(studentsRegisterFromDb);
        }
        [HttpPost]
        public IActionResult Edit(StudentsRegister obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Student updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }

            StudentsRegister? studentsRegisterFromDb = _db.Students.Find(id);
            if (studentsRegisterFromDb == null)
            {
                return NotFound();
            }

            return View(studentsRegisterFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            StudentsRegister? obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Students.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Student deleted syccessfully";
            return RedirectToAction("Index");
            
        }
    }
}
