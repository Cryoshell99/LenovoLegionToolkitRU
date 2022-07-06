using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Automation.Steps;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{
    public class FlipToStartAutomationStepControl : AbstractComboBoxAutomationStepCardControl<FlipToStartState>
    {
        public FlipToStartAutomationStepControl(IAutomationStep<FlipToStartState> step) : base(step)
        {
            Icon = SymbolRegular.Power24;
            Title = "Запуск открытием крышки";
            Subtitle = "Запустить ноутбук открытием крышки.";
        }
    }
}
