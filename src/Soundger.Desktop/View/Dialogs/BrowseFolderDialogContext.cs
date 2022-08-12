using bubuntoid.EasyDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundger.Desktop.View.Dialogs
{
    public class BrowseFolderDialogContext : DialogContext<BrowseFolderDialogContext>
    {
        public DialogSet<string> Path { get; set; }

        protected override void OnButtonClick()
        {
            
        }

        protected override void OnConfiguring(DialogContextConfigureOptionsBuilder<BrowseFolderDialogContext> builder)
        {
            builder
                .UseMetroStyle()
                .HasTitle("Browse directory")
                .HasNoButton();

            builder.Item(s => s.Path)
                .AsFullRow()
                .AsFolderBrowserDialog()
                .OnFolderSelected(s => Close());
        }
    }
}
