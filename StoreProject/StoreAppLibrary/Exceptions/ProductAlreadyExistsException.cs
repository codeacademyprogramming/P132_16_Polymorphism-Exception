using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary.Exceptions
{
    public class ProductAlreadyExistsException:Exception
    {
        public ProductAlreadyExistsException(string message):base(message)
        {
        }
    }
}
