﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionContainer
{
    class DependencyProvider : IDependencyProvider
    {
        public TDependency Resolve<TDependency>()
        {
            throw new NotImplementedException();
        }
    }
}
