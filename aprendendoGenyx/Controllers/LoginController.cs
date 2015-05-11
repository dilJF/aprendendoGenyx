using aprendendoGenyx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aprendendoGenyx.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(aprendendoGenyx.Models.usuario u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {
                using (db_chronos_biometria_homologEntities1 dc = new db_chronos_biometria_homologEntities1())
                {
                    //var v = dc.Usuarios.Where(a => a.NomeUsuario.Equals(u.NomeUsuario) && a.Senha.Equals(u.Senha)).FirstOrDefault();
                    var v = dc.usuario.Where(a => a.login.Equals(u.login) && a.senha.Equals(u.senha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.usuario_id.ToString();
                        Session["nomeUsuarioLogado"] = v.login.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(u);
        }

    }
}
