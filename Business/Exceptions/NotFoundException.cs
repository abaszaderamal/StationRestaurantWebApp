using System;

namespace Business.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string msg):base(msg)
        {
            
        }
        
    }
}