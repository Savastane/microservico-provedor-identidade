

namespace Application.General.Exceptions
{
    public class BadRequestException: Exception
    {
        private IDictionary<string, string[]> _dicionario;
        public BadRequestException(string message ) : base(message)
        {

        }
        public BadRequestException(string message, IDictionary<string, string[]> dicionario) : base(message)
        {
            _dicionario = dicionario;
        }

        public IDictionary<string, string[]> GetDicionario() { 
          return this._dicionario;
        }
        
    }
}
