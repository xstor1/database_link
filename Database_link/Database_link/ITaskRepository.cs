﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
   public interface ITaskRepository : IGenericRepository<Task>
    {
        Task GetSingle();
    }
}
