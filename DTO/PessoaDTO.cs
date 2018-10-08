using System.Collections.Generic;

namespace TodoApi.DTO {

    public enum Day { 
        Sun = 1, 
        Mon = 2,  
        Tue = 3,  
        Wed = 4,
        Thu = 5,  
        Fri = 6,  
        Sat = 7
    };

    /// <summary>
    /// Pessoa física
    /// </summary>
    public class PessoaDTO
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public List<TelefoneDTO> telefones;
        public Day dia { get; set; }
    }

}