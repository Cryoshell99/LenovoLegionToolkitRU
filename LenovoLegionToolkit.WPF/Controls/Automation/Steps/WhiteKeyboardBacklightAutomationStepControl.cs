using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Automation.Steps;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{

    public class WhiteKeyboardBacklightAutomationStepControl : AbstractComboBoxAutomationStepCardControl<WhiteKeyboardBacklightState>
    {
        public WhiteKeyboardBacklightAutomationStepControl(IAutomationStep<WhiteKeyboardBacklightState> step) : base(step)
        {
            Icon = SymbolRegular.Keyboard24;
            Title = "Подсветка клавиатуры";
            Subtitle = "Отрегулировать пресеты подсветки клавиатуры.";
        }
    }
}
