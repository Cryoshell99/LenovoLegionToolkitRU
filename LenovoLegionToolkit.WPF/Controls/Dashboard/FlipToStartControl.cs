using LenovoLegionToolkit.Lib;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public class FlipToStartControl : AbstractToggleFeatureCardControl<FlipToStartState>
    {
        protected override FlipToStartState OnState => FlipToStartState.On;

        protected override FlipToStartState OffState => FlipToStartState.Off;

        public FlipToStartControl()
        {
            Icon = SymbolRegular.Power24;
            Title = "Запуск открытием крышки";
            Subtitle = "Запустить ноутбук открытием крышки.";
        }
    }
}
