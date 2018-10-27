using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.BLL;
using TodoApi.DTO;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET api/persons
        [HttpGet]
        public List<PessoaDTO> Get()
        {
            PersonsBO personsBO = new PersonsBO();
            return personsBO.getPersons();
        }

        // GET api/persons/5
        [HttpGet("{id}")]
        public PessoaDTO Get(int id)
        {

            List<TelefoneDTO> telefones = new List<TelefoneDTO>(){
                new TelefoneDTO(){ ddd=71, numero=883860 },
                new TelefoneDTO(){ ddd=71, numero=919039 },
                new TelefoneDTO(){ ddd=71, numero=9176208 }
            };
            PessoaDTO Pessoa = new PessoaDTO();
            Pessoa.nome = "Paulo";
            Pessoa.sobrenome = "Henrique";
            Pessoa.telefones = telefones;
            return Pessoa;
        }

        // POST api/persons
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/persons/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/persons/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
