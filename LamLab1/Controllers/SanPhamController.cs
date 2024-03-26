using AppData.AllRepos;
using AppData.IRepos;
using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LamLab1.Controllers
{
    public class SanPhamController : Controller
    {
        AllRepos<SanPham> repo;
        DBLaptopContext context;
        public SanPhamController()
        {
            context = new DBLaptopContext();
            repo = new AllRepos<SanPham>(context, context.SanPhams);
        }
        public IActionResult Index()
        {
            var data = repo.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            var nhaSanXuatList = context.NhaSanXuats.ToList();
            var nhaSanXuatSelectList = nhaSanXuatList.Select(nsx =>
                new SelectListItem
                {
                    Text = nsx.TenNSX,
                    Value = nsx.MaNSX.ToString() 
                }).ToList();
            ViewBag.NhaSanXuatList = nhaSanXuatSelectList;
            var baoHanhList = context.BaoHanhs.ToList();
            var baoHanhSelectList = baoHanhList.Select(bh =>
                new SelectListItem
                {
                    Text = bh.MoTa,
                    Value = bh.MaBaoHanh.ToString()
                }).ToList();
            ViewBag.BaoHanhList = baoHanhSelectList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sanPham, Guid MaNSX, Guid MaBaoHanh)
        {
            var existingSanPham = repo.GetAll().FirstOrDefault(sp => sp.TenSanPham == sanPham.TenSanPham);
            if (existingSanPham != null)
            {
                ModelState.AddModelError("TenSanPham", "Sản phẩm đã tồn tại. Vui lòng chọn tên khác.");
                return View(sanPham);
            }
            sanPham.MaSanPham = Guid.NewGuid();
            sanPham.MaNSX = MaNSX;
            sanPham.MaBaoHanh = MaBaoHanh;
            repo.CreateObj(sanPham);
            return RedirectToAction("Index");
        }
        public IActionResult Update(Guid MaSanPham)
        {
            var sp = repo.GetByID(MaSanPham);
            ViewBag.NhaSanXuatList = new SelectList(context.NhaSanXuats, "MaNSX", "TenNSX");
            ViewBag.BaoHanhList = new SelectList(context.BaoHanhs, "MaBaoHanh", "MoTa");

            return View(sp);
        }


        [HttpPost]
        public IActionResult Update(SanPham sanPham)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.NhaSanXuatList = new SelectList(context.NhaSanXuats.ToList(), "MaNSX", "TenNSX", sanPham.MaNSX);
                ViewBag.BaoHanhList = new SelectList(context.BaoHanhs.ToList(), "MaBaoHanh", "MoTa", sanPham.MaBaoHanh);
                return View(sanPham);
            }
            repo.UpdateObj(sanPham);

            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid MaSanPham)
        {
            var sp = repo.GetByID(MaSanPham);
            return View(sp);
        }
        public IActionResult Delete(Guid MaSanPham)
        {
            var sanPham = repo.GetByID(MaSanPham);
            repo.DeleteObj(sanPham);
            return RedirectToAction("Index");
        }
    }
}
