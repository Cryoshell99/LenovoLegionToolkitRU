using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Automation.Steps;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{
    public class FnLockAutomationStepControl : AbstractComboBoxAutomationStepCardControl<FnLockState>
    {
        public FnLockAutomationStepControl(IAutomationStep<FnLockState> step) : base(step)
        {
            Icon = SymbolRegular.Keyboard24;
            Title = "Fn Lock";
            Subtitle = "Использовать функции верхнего ряда F1-F12 без клавиши Fn.";
        }
    }
}
