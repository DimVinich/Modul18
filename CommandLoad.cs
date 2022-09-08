using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul18
{
    class CommandLoad : ICommand
    {
        YoutubeReceiver receiver;

        public CommandLoad(YoutubeReceiver receiver)
        {
            this.receiver = receiver;
        }

        public async Task Load(string url)
        {
            await receiver.OperationDownload(url);
        }

    }
}
