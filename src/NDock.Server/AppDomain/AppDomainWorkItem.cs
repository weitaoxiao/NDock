﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDock.Base;
using NDock.Base.Config;

namespace NDock.Server.AppDomain
{
    class AppDomainWorkItem : IWorkItem
    {
        public bool Setup(IServerConfig config, IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
