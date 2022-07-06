using LenovoLegionToolkit.Lib.Automation;
using LenovoLegionToolkit.Lib.Automation.Steps;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Automation.Steps
{
    public class DeactivateGPUAutomationStepControl : AbstractComboBoxAutomationStepCardControl<DeactivateGPUAutomationStepState>
    {
        public DeactivateGPUAutomationStepControl(DeactivateGPUAutomationStep step) : base(step)
        {
            Icon = SymbolRegular.DeveloperBoard24;
            Title = "Отключение GPU";
            Subtitle = "Отключить дискретный графический процессор, если он не нужен.\n\nВНИМАНИЕ: Это действие не будет выполняться корректно,\nесли внутренний дисплей выключен или гибридный режим не активен.";
        }
    }
}
