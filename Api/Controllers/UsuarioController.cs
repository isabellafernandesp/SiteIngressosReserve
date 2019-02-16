using DataBase.Connection;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class UsuarioController : ApiController
    {
        private Repository<Usuario> _repository;

        public UsuarioController()
        {
            _repository = new Repository<Usuario>();
        }

        [HttpGet]
        [Route("api/usuario/get/{id}")]
        public Usuario Get(int id)
        {
            try
            {
                var qry = _repository.GetQuery();
                var res = qry.FirstOrDefault(x => x.Id == id);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("api/usuario/get/{email}/{senha}")]
        public Usuario Get(string email, string senha)
        {
            try
            {
                var qry = _repository.GetQuery();
                var res = qry.FirstOrDefault(x => x.Email.Equals(email) && x.Senha.Equals(senha));
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("api/usuario/list")]
        public IHttpActionResult GetAll( )
        {
            try
            {
                var qry = _repository.GetQuery();
                var res = qry.ToList();
                return Json(res);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("api/usuario/insert")]
        public IHttpActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                _repository.Insert(usuario);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("api/usuario/update")]
        public IHttpActionResult Put([FromBody]Usuario usuario)
        {
            try
            {
                _repository.Update(usuario);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/usuario/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _repository.Delete(Get(id));
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
