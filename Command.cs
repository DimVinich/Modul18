using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul18
{
    interface ICommand
    {
       Task Load(string url);
    }
}
