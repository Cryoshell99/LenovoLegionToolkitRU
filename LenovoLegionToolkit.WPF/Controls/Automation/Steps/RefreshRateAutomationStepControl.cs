using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Automation.Steps;
using LenovoLegionToolkit.Lib.Listeners;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{
    public class RefreshRateAutomationStepControl : AbstractComboBoxAutomationStepCardControl<RefreshRate>
    {
        private readonly DisplayConfigurationListener _listener = IoCContainer.Resolve<DisplayConfigurationListener>();

        public RefreshRateAutomationStepControl(IAutomationStep<RefreshRate> step) : base(step)
        {
            Icon = SymbolRegular.Laptop24;
            Title = "Частота обновления экрана";
            Subtitle = "Изменить частоту обновления встроенного дисплея.\n\nВНИМАНИЕ: Это действие не будет выполняться корректно,\nесли внутренний дисплей выключен.";

            _listener.Changed += Listener_Changed;
        }

        private void Listener_Changed(object? sender, System.EventArgs e) => Dispatcher.Invoke(async () =>
        {
            if (IsLoaded && IsVisible)
                await RefreshAsync();
        });
    }
}
