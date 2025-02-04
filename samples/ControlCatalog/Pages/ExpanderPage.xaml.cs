using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalog.ViewModels;

namespace ControlCatalog.Pages
{
    public class ExpanderPage : UserControl
    {
        public ExpanderPage()
        {
            this.InitializeComponent();
            DataContext = new ExpanderPageViewModel();

            var CollapsingDisabledExpander = this.Get<Expander>("CollapsingDisabledExpander");
            var ExpandingDisabledExpander = this.Get<Expander>("ExpandingDisabledExpander");

            CollapsingDisabledExpander.Collapsing += (s, e) => { e.Handled = true; };
            ExpandingDisabledExpander.Expanding += (s, e) => { e.Handled = true; };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
