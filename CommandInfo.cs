using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Modul18
{
    class CommandInfo: ICommand
    {
        YoutubeReceiver receiver;

        public CommandInfo(YoutubeReceiver receiver)
        {
            this.receiver = receiver;
        }
       
        public async Task Load(string url)
        {
            await receiver.OperationInfo(url);
        }
       
    }
}
