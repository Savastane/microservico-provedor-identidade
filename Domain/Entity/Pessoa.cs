using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace systemsecurity.domain
{
    public class Pessoa
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string Nome { get; set; }
        public string Documento{ get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Alcunha{ get; set; }        
        public string IdExterno{ get; set; }
        public int Bloqueado { get; set; }
        public int Exclusao { get; set; }

    }
}
