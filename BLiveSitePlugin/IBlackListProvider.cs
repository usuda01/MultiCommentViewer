using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLiveSitePlugin
{
    interface IBlackListProvider
    {
        event EventHandler<List<string>> Received;

        void Disconnect();
        Task ReceiveAsync(string movieId, Context context);
    }
}