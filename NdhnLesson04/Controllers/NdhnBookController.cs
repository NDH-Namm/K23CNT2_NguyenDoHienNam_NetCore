using Microsoft.AspNetCore.Mvc;
using NdhnLesson04.Models;

namespace NdhnLesson04.Controllers
{
    public class NdhnBookController : Controller
    {

        private List<NdhnBook> ndhnBooks = new List<NdhnBook>
        {
             new NdhnBook
            {
                NdhnId = "B001",
                NdhnTitle = "Hành Trình Bắt Đầu Từ Con Số 0",
                NdhnDescription = "Cuốn sách truyền cảm hứng về cách một người bình thường có thể xây dựng sự nghiệp bền vững từ những bước đi nhỏ nhất.",
                NdhnImage = "images/book-1.jpg",
                NdhnPrice = 120000f,
                NdhnPage = 256
            },
            new NdhnBook
            {
                NdhnId = "B002",
                NdhnTitle = "Giai Điệu của Thành Công",
                NdhnDescription = "Tác phẩm khai thác nghệ thuật lãnh đạo qua lăng kính âm nhạc, giúp bạn tìm ra giai điệu riêng để chạm tới đỉnh cao.",
                NdhnImage = "images/book-2.jpg",
                NdhnPrice = 95000f,
                NdhnPage = 198
            },
            new NdhnBook
            {
                NdhnId = "B003",
                NdhnTitle = "Bí Kíp Quản Trị Thời Gian",
                NdhnDescription = "Hướng dẫn chi tiết cách lên kế hoạch, ưu tiên công việc, và loại bỏ sự trì hoãn để đạt hiệu suất tối đa.",
                NdhnImage = "images/book-3.jpg",
                NdhnPrice = 80000f,
                NdhnPage = 180
            },
            new NdhnBook
            {
                NdhnId = "B004",
                NdhnTitle = "Chạm Vào Tương Lai: Công Nghệ Và Đời Sống",
                NdhnDescription = "Tổng hợp những xu hướng công nghệ nổi bật và dự báo tác động của chúng đến xã hội trong thập kỷ tới.",
                NdhnImage = "images/book-4.jpg",
                NdhnPrice = 150000f,
                NdhnPage = 320
            },
            new NdhnBook
            {
                NdhnId = "B005",
                NdhnTitle = "Hành Trình Phượt Việt Nam",
                NdhnDescription = "Cẩm nang du lịch bụi qua các vùng miền Việt Nam, kèm hình ảnh, hướng dẫn chi tiết và mẹo vặt hữu ích.",
                NdhnImage = "images/book-5.jpg",
                NdhnPrice = 110000f,
                NdhnPage = 272
            }
        };
        


        // GET: /NdhnBook/NdhnIndex => Lấy tất cả các cuốn sách
        public IActionResult NdhnIndex()
        {
            // Đưa dữ liệu lên view

            return View(ndhnBooks);
        }

        // GET: /NdhnBook/NdhnCreate
        public IActionResult NdhnCreate()
        {
            NdhnBook ndhnBook = new NdhnBook();

            return View(ndhnBook);
        }

        // POST: /NdhnBook/NdhnCreate
        public IActionResult NdhnCreateSubmit ()
        {
            return RedirectToAction("NdhnIndex");
        }

        // GET: /NdhnBook/NdhnCreate
        public IActionResult NdhnEdit(string id)
        {
            return View();
        }

        // POST: /NdhnBook/NdhnEditSubmit
        public IActionResult NdhnEditSubmit()
        {
            //...
            return RedirectToAction("NdhnIndex");
        }
    }
}
