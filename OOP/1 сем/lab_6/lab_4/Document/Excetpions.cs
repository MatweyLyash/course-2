using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public abstract class Excetpions:Exception
    {
        public int Code { get; set; }
        public string Message { get; set; }
    
        public Excetpions(int code, string message )
        {
            Code = code;
            Message = message;
                    
        }
        public override string ToString()
        {
            return $"код ошибки {Code}, сообщение {Message}";
        }
    }
    
}
