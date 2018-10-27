using System.Collections.Generic;
using TodoApi.DTO;

namespace TodoApi.BLL
{
    public class PersonsBO
    {
        public List<PessoaDTO> getPersons()
        {
            List<PessoaDTO> Pessoas = new List<PessoaDTO>();

            var Nomes = new List<string> {
                "Paulo Henrique",
                "Raylane Ribeiro",
                "Moises Bottas",
                "Dalva Santos",
                "Laura Ribeiro"
            };

            int Count = 0;
            foreach (var Nome in Nomes)
            {
                PessoaDTO Pessoa = new PessoaDTO();
                string[] NomeSobrenome = Nome.Split(' ');

                List<TelefoneDTO> telefones = new List<TelefoneDTO>(){
                    new TelefoneDTO(){ ddd=71, numero=88398760 + Count, tipo = "Celular" },
                    new TelefoneDTO(){ ddd=71, numero=91920139 + Count },
                    new TelefoneDTO(){ ddd=71, numero=91760208 + Count }
                };

                Pessoa.nome = NomeSobrenome[0];
                Pessoa.sobrenome = NomeSobrenome[1];
                Pessoa.telefones = telefones;
                Pessoa.dia = (Day)9;
                Pessoas.Add(Pessoa);

                Count++;
                telefones = null;
                Pessoa = null;
            }
            return Pessoas;

        }
    }
}