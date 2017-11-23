using System;
using System.Linq;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace CloseAdditionalToolOutputPads
{
    public class ClosePadsHandler : CommandHandler
    {
        protected override void Run()
        {
            IdeApp.Workbench.Pads
                  .Where(pad => pad.Id.StartsWith("OutputPad-MonoDevelop.Ide.ToolOutput", StringComparison.CurrentCulture))
                  .Where(pad => !pad.Id.EndsWith("-0", StringComparison.CurrentCulture))
                  .ToList()
                  .ForEach(pad => pad.Destroy());
        }
    }
}
