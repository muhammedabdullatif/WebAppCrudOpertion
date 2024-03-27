using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCrudOpertion.Data;
using WebAppCrudOpertion.Models;

namespace WebAppCrudOpertion.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplictionDbContext _context;

        public EmployeesController(ApplictionDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            //var Result = _context.Employees.Where(x=>x.EmployeeName == "ali" && x.NationalId == "2").Include(x => x.Department).OrderBy(x => x.EmployeeName).ToList();
          //  var Result = _context.Employees.Where(x=>x.Salary>20000 && x.EmployeeName=="ali").Include(x => x.Department).OrderBy(x => x.EmployeeName).ToList();


            var Result = _context.Employees.Include(x => x.Department).OrderBy(x => x.EmployeeName).ToList();
            return View(Result);
        }
        public IActionResult Create() 
        {
           ViewBag.Departments =_context.Departments.OrderBy(x=>x.DepartmentName).ToList();
            return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee model)
            {
      
            if (ModelState.IsValid)
            {
                _context.Employees.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Departments =_context.Departments.OrderBy(x=>x.DepartmentName).ToList();
           ViewBag
            return View();

        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }

            var result = _context.Employees.Find(id);
            ViewBag.Departments = _context.Departments.OrderBy(x => x.DepartmentName).ToList();
            return View("Create", result);
        }

        public void UploadImage(Employee model)
        {
            var file = HttpContext.Request.Form.Files;
            if (file.Count() > 0)
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
                var filestream = new FileStream(Path.Combine(@"wwwroot/images", ImageName), FileMode.Create);
                file[0].CopyTo(filestream);
                model.ImageUser = ImageName;

            }
            else if (model.ImageUser == null && model.EmployeeId == null)
            {
                model.ImageUser = "DefaultImage.png";
            }
            else
            {
                model.ImageUser = model.ImageUser;
            }
        }
    }
}
