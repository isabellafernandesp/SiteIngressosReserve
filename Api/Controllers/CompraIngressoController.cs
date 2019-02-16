using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataBase.Connection;
using Models.Model;

namespace Api.Controllers
{
    public class CompraIngressoController : ApiController
    {
        private Repository<CompraIngressos> _repository;

        public CompraIngressoController()
        {
            _repository = new Repository<CompraIngressos>();
        }

        [HttpGet]
        [Route("api/compraIngresso/get/{id}")]
        public CompraIngressos Get(int id)
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
        [Route("api/compraIngresso/list")]
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
        [Route("api/compraIngresso/insert")]
        public IHttpActionResult Post([FromBody]CompraIngressos compraIngresso)
        {
            try
            {
                _repository.Insert(compraIngresso);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("api/compraIngresso/update")]
        public IHttpActionResult Put([FromBody]CompraIngressos compraIngresso)
        {
            try
            {
                _repository.Update(compraIngresso);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/compraIngresso/delete/{id}")]
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
