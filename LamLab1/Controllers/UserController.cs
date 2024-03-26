using AppData.AllRepos;
using AppData.Models;
using Microsoft.AspNetCore.Mvc;

namespace LamLab1.Controllers
{
    public class UserController : Controller
    {
        AllRepos<User> repo;
        DBLaptopContext context;
        public UserController()
        {
            // Khởi tạo DbContext
            context = new DBLaptopContext();
            //  Khởi tạo 1 repo với 2 tham số bao gồm: context và DbSet<User> để khi dùng thì
            //  DbSet được trỏ đến có thể thao tác trên bảng User
            repo = new AllRepos<User> (context, context.Users);

        }
        //  Lấy ra Data
        public IActionResult Index()
        {
            var data = repo.GetAll(); // Lấy tất cả danh sách của User
            return View(data);
        }
        // Tạo mới
        public IActionResult Create()   // Action này để mở form, trả về View Create để điền thông tin
        {
            return View(); 

        }
        [HttpPost]
        public IActionResult Create(User user)  // Action này để xử lí data và thêm vào Database
        {
            var existingUser = repo.GetAll().FirstOrDefault(u => u.TenUser == user.TenUser);
            if (existingUser != null)
            {
                ModelState.AddModelError("TenUser", "Tên người dùng đã tồn tại. Vui lòng chọn tên khác.");
                return View(user);
            }
            user.MaUser = Guid.NewGuid();
            repo.CreateObj(user);
            return RedirectToAction("Index");
        }
        public IActionResult Update(Guid MaUser)
        {
            var user = repo.GetByID(MaUser);
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            repo.UpdateObj(user);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid MaUser)
        {
            var user = repo.GetByID(MaUser);
            repo.DeleteObj(user);
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = repo.GetAll().FirstOrDefault(p => p.TenUser == username && p.MatKhau == password);
            // SingleOrDefault (xử lí khi tài khoản & pass giống nhau)
            if (user != null)
            {
                TempData["TenUser"] = username;
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.";
                return RedirectToAction("Login");
            }
        }
    }
}
