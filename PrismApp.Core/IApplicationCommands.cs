using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core
{
    public interface IApplicationCommands
    {
        CompositeCommand MainCommand { get; }
    }
}
