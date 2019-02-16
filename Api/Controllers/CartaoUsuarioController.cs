using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DataBase.Connection;
using Models.Model;

namespace Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CartaoUsuarioController : ApiController
    {
        private Repository<CartaoUsuario> _repository;

        public CartaoUsuarioController()
        {
            _repository = new Repository<CartaoUsuario>();
        }

        [HttpGet]
        [Route("api/cartaoUsuario/get/{id}")]
        public CartaoUsuario Get(int id)
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
        [Route("api/cartaoUsuario/list")]
        public IHttpActionResult GetAll()
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
        [Route("api/cartaoUsuario/insert")]
        public IHttpActionResult Post([FromBody]CartaoUsuario cartaoUsuario)
        {
            try
            {
                _repository.Insert(cartaoUsuario);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("api/cartaoUsuario/update")]
        public IHttpActionResult Put([FromBody]CartaoUsuario cartaoUsuario)
        {
            try
            {
                _repository.Update(cartaoUsuario);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/cartaoUsuario/delete/{id}")]
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
