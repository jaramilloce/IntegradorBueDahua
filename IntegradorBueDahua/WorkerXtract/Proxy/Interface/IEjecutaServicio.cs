using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerXtract.Proxy.Interface
{
    public interface IEjecutaServicio
    {
        Task<object> EjecutaServicio();
    }
}
