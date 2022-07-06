using System.ComponentModel.DataAnnotations;

namespace LenovoLegionToolkit.Lib.Automation
{
    public enum DeactivateGPUAutomationStepState
    {
        [Display(Name = "Закрыть приложения")]
        KillApps,
        [Display(Name = "Перезапустить GPU")]
        RestartGPU,
    }
}
