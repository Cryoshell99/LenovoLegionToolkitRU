using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Automation.Steps;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{
    public class AlwaysOnUsbAutomationStepControl : AbstractComboBoxAutomationStepCardControl<AlwaysOnUSBState>
    {
        public AlwaysOnUsbAutomationStepControl(IAutomationStep<AlwaysOnUSBState> step) : base(step)
        {
            Icon = SymbolRegular.UsbStick24;
            Title = "USB всегда включен";
            Subtitle = "Заряжайте USB-устройства, когда компьютер\nнаходится в режиме сна, гибернации или выключен.";
        }
    }
}
