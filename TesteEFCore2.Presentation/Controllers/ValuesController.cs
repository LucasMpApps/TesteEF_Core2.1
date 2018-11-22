using System;
using Microsoft.AspNetCore.Mvc;
using TesteEFCore2.Domain.Entities;
using TesteEFCore2.Domain.Interfaces.Repository;

namespace TesteEFCore2.Presentation.Controllers
{
    public class ValuesController : Controller
    {
        private readonly IUsuarioRepository _repository;

        public ValuesController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("usuario")]
        public JsonResult Get()
        {
            return Json(_repository.GetAll());
        }

        [HttpGet]
        [Route("usuario/{id:Guid}")]
        public JsonResult Get(Guid id)
        {
            var result = _repository.GetById(id);
            return Json(result);
        }

        // POST api/values
        [HttpPost]
        [Route("usuario")]
        public void Post([FromBody]Usuario model)
        {
            _repository.Add(model);

            _repository.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        [Route("usuario")]
        public void Put([FromBody]Usuario model)
        {
            _repository.Update(model);

            _repository.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("usuario/{id:Guid}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);

            _repository.SaveChanges();
        }
    }
}
