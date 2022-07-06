using System.Threading.Tasks;
using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Features;
using LenovoLegionToolkit.Lib.System;
using LenovoLegionToolkit.WPF.Utils;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public class HybridModeControl : AbstractToggleFeatureCardControl<HybridModeState>
    {
        protected override HybridModeState OnState => HybridModeState.On;

        protected override HybridModeState OffState => HybridModeState.Off;

        public HybridModeControl()
        {
            Icon = SymbolRegular.LeafOne24;
            Title = "Гибридный режим";
            Subtitle = "Позволяет переключаться между интегрированным и дискретным GPU.\nТребуется перезапуск.";
        }

        protected override async Task OnStateChange(ToggleSwitch toggle, IFeature<HybridModeState> feature)
        {
            var result = await MessageBoxHelper.ShowAsync(
                this,
                "Требуется перезапуск",
                "Переключение гибридного режима требует перезагрузк. Вы хотите перезапустить сейчас?");

            if (result)
            {
                await base.OnStateChange(toggle, feature);
                await Power.RestartAsync();
            }
            else
                toggle.IsChecked = !toggle.IsChecked;
        }
    }
}
