using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiCoreEF.Model;
using ApiCoreEF.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreEF.Controllers
{

    [EnableCors("AllowOrigin")]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _repository;

        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        [Route("get-users")]
        [HttpGet]
        public IEnumerable<User> Get()
        {            
            return _repository.Get();
        }

        [Route("create-user")]
        [HttpPost]
        public Response Post([FromBody] User user)
        {
            _repository.Create(user);

            var response = new Response();
            response = new Response(HttpStatusCode.OK, "Usuário cadastrado com sucesso !");

            return response;
        }

        [Route("update-user")]
        [HttpPut]
        public Response Put([FromBody] User user)
        {
            _repository.Update(user);

            var response = new Response();
            response = new Response(HttpStatusCode.OK, "Usuário atualizado com sucesso !");

            return response;
        }

        [Route("delete-user/{idUser}")]
        [HttpDelete]
        public Response Delete(int idUser)
        {
            User user = new User();
            user.IdUser = idUser;
            _repository.Delete(user);

            var response = new Response();
            response = new Response(HttpStatusCode.OK, "Usuário excluído com sucesso !");

            return response;
        }

    }
}
