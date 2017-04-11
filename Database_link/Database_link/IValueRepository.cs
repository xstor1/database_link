using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    public interface IValueRepository : IGenericRepository<Value>
    {
        Value GetSingle(int barId);
    }
}
