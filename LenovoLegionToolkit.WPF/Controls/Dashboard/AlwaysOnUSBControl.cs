using LenovoLegionToolkit.Lib;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public class AlwaysOnUSBControl : AbstractComboBoxFeatureCardControl<AlwaysOnUSBState>
    {
        public AlwaysOnUSBControl()
        {
            Icon = SymbolRegular.UsbStick24;
            Title = "USB всегда включен";
            Subtitle = "Заряжайте USB-устройства, когда компьютер\nнаходится в режиме сна, гибернации или выключен.";
        }
    }
}
