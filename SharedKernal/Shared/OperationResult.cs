using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernal.Shared
{
     public class OperationResult<T> where T : class
    {
        public T Result { get; set; }

        public IEnumerable<T> ResultList { get; set; }

        public Exception Exception { get; set; }

    }
}
