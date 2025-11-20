using InfoCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Services;

public interface IClientCheckService
{
    public Task HandleConnectionInfo(RemoteConnectionInfo info);
}
