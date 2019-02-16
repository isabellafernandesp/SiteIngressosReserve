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
    public class EventoController : ApiController
    {
        private Repository<Evento> _repository;

        public EventoController()
        {
            _repository = new Repository<Evento>();
        }

        [HttpGet]
        [Route("api/evento/get/{id}")]
        public Evento Get(int id)
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
        [Route("api/evento/list")]
        public List<Evento> GetAll()
        {
            try
            {
                var qry = _repository.GetQuery();
                var res = qry.ToList();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("api/evento/list-proximos-eventos")]
        public List<Evento> GetProximosEventosDisponiveis()
        {
            try
            {
                var qry = _repository.GetQuery();
                var res = qry.Where(x => (x.DataHoraEvento > DateTime.Now) && (x.TotalIngressos > x.TotalVendidos)).ToList();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("api/evento/insert")]
        public IHttpActionResult Post([FromBody]Evento evento)
        {
            try
            {
                _repository.Insert(evento);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("api/evento/update")]
        public IHttpActionResult Put([FromBody]Evento evento)
        {
            try
            {
                _repository.Update(evento);
                _repository.SaveChanges();
                return Json("OK");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/evento/delete/{id}")]
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
