﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NMS.SubscriptionService.Plugins.Interfaces
{
    public interface IDeviceStrategy
    {
        void Register(HttpRequestBase request);
        void Unregister(HttpRequestBase request);
    }
}
