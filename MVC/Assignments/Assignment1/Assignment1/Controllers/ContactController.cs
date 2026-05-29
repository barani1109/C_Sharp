using System.Threading.Tasks;
using System.Web.Mvc;
using Assignment1.Models;
using Assignment1.Repository;

namespace Assignment1.Controllers
{
    public class ContactController : Controller
    {
        IRepository<Contact> repo;

        public ContactController()
        {
            repo = new ContactRepository();
        }

        public async Task<ActionResult> Index()
        {
            var data = await repo.GetAllAsync();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Contact c)
        {
            if (ModelState.IsValid)
            {
                await repo.InsertAsync(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }

        public async Task<ActionResult> Delete(long id)
        {
            await repo.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}