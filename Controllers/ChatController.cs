using Module5_TP1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Module5_TP1.Controllers
{
    public class ChatController : Controller
    {
        private List<Chat> meuteChats = Chat.GetMeuteDeChats();

        // GET: Chat
        public ActionResult Index()
        {
            return View(meuteChats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat chat = meuteChats.SingleOrDefault(c => c.Id == id);
            if (chat == null)
            {
                return RedirectToAction("Index");
            }
            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat chat = meuteChats.SingleOrDefault(c => c.Id == id);
            if (chat == null)
            {
                return RedirectToAction("Index");
            }
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Chat chat = meuteChats.SingleOrDefault(c => c.Id == id);
                if (chat != null)
                {
                    meuteChats.Remove(chat);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
