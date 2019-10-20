using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using smurfis.Models;
using smurfis.ModelViews;
using smurfis.util;

namespace smurfis.Controllers
{
    public class TeachersController : Controller
    {
        private PreSchoolData db = new PreSchoolData();

        // GET: Teachers
        public async Task<ActionResult> Index()
        {
            return View(await db.teachers.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = await db.teachers.FindAsync(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TeacherEmployee teacher)
        {
   

            if (ModelState.IsValid)
            {
                HashPassword hashPassword = new HashPassword(teacher.ePassword);

                // teacher.employee.Salt = hashPassword.getSalted();
                // teacher.employee.ePassword = hashPassword.getHash();
                // teacher.teacher.ID_teacher = Guid.NewGuid();
                Guid employeeID = Guid.NewGuid();
                // teacher.teacher.ID_Employee = teacher.employee.ID_Employee;
                // db.employees.Add(teacher.employee);
                //  db.teachers.Add(teacher.teacher);
                //  await db.SaveChangesAsync();
                //return RedirectToAction("Index");
                var employee = new Employee
                {
                    ID_Employee = employeeID,
                    ePassword = hashPassword.getHash(),
                    eAddress = teacher.eAddress,
                    eJobDescription = teacher.eJobDescription,
                    eJobTitle = teacher.eJobTitle,
                    email = teacher.email,
                    eSurname = teacher.eSurname,
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    eName = teacher.eName,
                    ePhoneNumber = teacher.ePhoneNumber,
                    Salt=hashPassword.getSalted()
                };
                var tec = new Teacher
                {
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    ID_Employee = employeeID,
                    ID_teacher = Guid.NewGuid()
                };
                 db.employees.Add(employee);
                  db.teachers.Add(tec);
                  await db.SaveChangesAsync();
                return Json(employee);

            }

            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = await db.teachers.FindAsync(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_teacher,ID_Employee,Created,Modified")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = await db.teachers.FindAsync(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Teacher teacher = await db.teachers.FindAsync(id);
            db.teachers.Remove(teacher);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
