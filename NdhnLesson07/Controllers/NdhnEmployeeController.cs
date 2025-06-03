using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NdhnLesson07.Models;

namespace NdhnLesson07.Controllers
{
    public class NdhnEmployeeController : Controller
    {
        //Mock data:
        private static List<NdhnEmployee> ndhnListEmployee = new List<NdhnEmployee>()
        {
            new NdhnEmployee
            {
                NdhnId = 231090007,
                NdhnName = "Nguyễn Đỗ Hiền Nam",
                NdhnBirthDay = new DateTime(2005, 10, 26),
                NdhnEmail = "namlong145@gmail.com",
                NdhnPhone = "0363917906",
                NdhnSalary = 15000000,
                NdhnStatus = true
            },
            new NdhnEmployee
            {
                NdhnId = 2,
                NdhnName = "Tran Thi B",
                NdhnBirthDay = new DateTime(1988, 3, 8),
                NdhnEmail = "ttb@example.com",
                NdhnPhone = "0912345678",
                NdhnSalary = 12000000,
                NdhnStatus = true
            },
            new NdhnEmployee
            {
                NdhnId = 3,
                NdhnName = "Le Van C",
                NdhnBirthDay = new DateTime(1995, 11, 23),
                NdhnEmail = "lvc@example.com",
                NdhnPhone = "0923456789",
                NdhnSalary = 10000000,
                NdhnStatus = false
            },
            new NdhnEmployee
            {
                NdhnId = 4,
                NdhnName = "Pham Thi D",
                NdhnBirthDay = new DateTime(1992, 7, 19),
                NdhnEmail = "ptd@example.com",
                NdhnPhone = "0934567890",
                NdhnSalary = 13000000,
                NdhnStatus = true
            },
            new NdhnEmployee
            {
                NdhnId = 5,
                NdhnName = "Hoang Van E",
                NdhnBirthDay = new DateTime(1998, 9, 1),
                NdhnEmail = "hve@example.com",
                NdhnPhone = "0945678901",
                NdhnSalary = 11000000,
                NdhnStatus = false
            }
        };

        public static List<NdhnEmployee> NdhnListEmployee { get => ndhnListEmployee; set => ndhnListEmployee = value; }

        // GET: NdhnEmployeeController
        public ActionResult NdhnIndex()
        {
            return View(ndhnListEmployee);
        }

        // GET: NdhnEmployeeController/NdhnDetails/5
        public ActionResult NdhnDetails(int id)
        {
            var ndhnEmployee = ndhnListEmployee.FirstOrDefault(x => x.NdhnId == id);
            return View(ndhnEmployee);
        }

        // GET: NdhnEmployeeController/NdhnCreate
        public ActionResult NdhnCreate()
        {
            var ndhnEmployee = new NdhnEmployee();
            return View(ndhnEmployee);
        }

        // POST: NdhnEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdhnCreate(NdhnEmployee ndhnModel)
        {
            try
            {
                //Thêm mới nhân viên vào list 
                ndhnModel.NdhnId = ndhnListEmployee.Max(x => x.NdhnId) + 1;
                ndhnListEmployee.Add(ndhnModel);
                return RedirectToAction(nameof(NdhnIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NdhnEmployeeController/NdhnEdit/5
        public ActionResult NdhnEdit(int id)
        {
            var ndhnEmployee = ndhnListEmployee.FirstOrDefault(x => x.NdhnId == id);
            return View(ndhnEmployee);
        }

        // POST: NdhnEmployeeController/NdhnEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NdhnEdit(int id, NdhnEmployee ndhnModel)
        {
            try
            {
                for (int i = 0; i < ndhnListEmployee.Count(); i++)
                {
                    if (ndhnListEmployee[i].NdhnId == id) 
                    {
                        ndhnListEmployee[i] = ndhnModel;
                        break;
                    }
                }    
                return RedirectToAction(nameof(NdhnIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NdhnEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NdhnEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
