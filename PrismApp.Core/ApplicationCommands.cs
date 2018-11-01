using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Core
{
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand MainCommand { get; } = new CompositeCommand();
    }
}
