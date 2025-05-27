using Microsoft.AspNetCore.Mvc;
using NdhnLab06.Models;

namespace NdhnLab06.Controllers
{
    public class NdhnEmployeeController : Controller
    {
        private static List<NdhnEmployee> ndhnListEmployee = new List<NdhnEmployee>()
        {
            new NdhnEmployee { NdhnId = 1, NdhnName = "Nguyễn Đỗ Hiền Nam", NdhnBirthDay = new DateTime(2005,1,26), NdhnEmail = "namlong145@gmail.com", NdhnPhone = "0363917906", NdhnSalary = 18000000, NdhnStatus = true },
            new NdhnEmployee { NdhnId = 2, NdhnName = "Nguyễn Đỗ Hiền ", NdhnBirthDay = new DateTime(2005,10,6), NdhnEmail = "namlong14@gmail.com", NdhnPhone = "036391790", NdhnSalary = 17000000, NdhnStatus = false },
            new NdhnEmployee { NdhnId = 3, NdhnName = "Nguyễn Đỗ ", NdhnBirthDay = new DateTime(2005,10,2), NdhnEmail = "namlong1@gmail.com", NdhnPhone = "03639179", NdhnSalary = 16000000, NdhnStatus = true },
            new NdhnEmployee { NdhnId = 4, NdhnName = "Nguyễn ", NdhnBirthDay = new DateTime(2005,10,16), NdhnEmail = "namlong@gmail.com", NdhnPhone = "0363917", NdhnSalary = 15000000, NdhnStatus = false },
            new NdhnEmployee { NdhnId = 5, NdhnName = "N", NdhnBirthDay = new DateTime(2005,10,23), NdhnEmail = "namlon1@gmail.com", NdhnPhone = "036391", NdhnSalary = 14000000, NdhnStatus = true }
        };
        public IActionResult NdhnIndex()
        {
            return View(ndhnListEmployee);
        }

        public IActionResult NdhnCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NdhnCreate(NdhnEmployee newEmp)
        {
            if (ModelState.IsValid)
            {
                // Tự động tạo ID mới dựa vào phần tử cuối cùng trong danh sách
                newEmp.NdhnId = ndhnListEmployee.Count > 0
                                ? ndhnListEmployee[^1].NdhnId + 1
                                : 1;

                // Thêm nhân viên mới vào danh sách
                ndhnListEmployee.Add(newEmp);

                // Chuyển hướng về danh sách sau khi thêm thành công
                return RedirectToAction("NdhnIndex");
            }

            // Nếu dữ liệu không hợp lệ, quay lại view với dữ liệu đã nhập
            return View(newEmp);
        }
    }
}
 