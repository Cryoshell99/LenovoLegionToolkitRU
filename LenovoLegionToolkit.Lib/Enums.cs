using System.ComponentModel.DataAnnotations;

namespace LenovoLegionToolkit.Lib
{
    public enum AlwaysOnUSBState
    {
        [Display(Name = "Выключено")]
        Off,
        [Display(Name = "Включено, в спящем режиме")]
        OnWhenSleeping,
        [Display(Name = "Включено, всегда")]
        OnAlways,
    }


    public enum BatteryState
    {
        [Display(Name = "Сберегательный режим)]
        Conservation,
        [Display(Name = "Обычный режим")]
        Normal,
        [Display(Name = "Экспресс-зарядка")]
        RapidCharge,
    }

    public enum FlipToStartState
    {
        [Display(Name = "ВЫКЛ")]
        Off,
        [Display(Name = "ВКЛ")]
        On,
    }

    public enum FnLockState
    {
        [Display(Name = "ВЫКЛ")]
        Off,
        [Display(Name = "ВКЛ")]
        On,
    }

    public enum HybridModeState
    {
        [Display(Name = "ВКЛ")]
        On,
        [Display(Name = "ВЫКЛ")]
        Off,
    }

    public enum OverDriveState
    {
        [Display(Name = "ВЫКЛ")]
        Off,
        [Display(Name = "ВКЛ")]
        On,
    }

    public enum PowerModeState
    {
        [Display(Name = "Тихий")]
        Quiet,
        [Display(Name = "Сбалансировыанный")]
        Balance,
        [Display(Name = "Производительный")]
        Performance,
    }

    public enum ProcessEventInfoType
    {
        [Display(Name = "Запущено")]
        Started,
        [Display(Name = "Остановлено")]
        Stopped,
    }

    public enum RGBKeyboardBacklightChanged { }

    public enum RGBKeyboardBrightness
    {
        [Display(Name = "Низкая")]
        Low,
        [Display(Name = "Высокая")]
        High,
    }

    public enum RGBKeyboardEffect
    {
        [Display(Name = "Статичный")]
        Static,
        [Display(Name = "Дыхание")]
        Breath,
        [Display(Name = "Плавный")]
        Smooth,
        [Display(Name = "Волна Вправо")]
        WaveRTL,
        [Display(Name = "Волна Влево")]
        WaveLTR,
    }

    public enum RGBKeyboardBacklightPreset
    {
        [Display(Name = "Выкл.")]
        Off = -1,
        [Display(Name = "Профиль 1")]
        One = 0,
        [Display(Name = "Профиль 2")]
        Two = 1,
        [Display(Name = "Профиль 3")]
        Three = 2,
    }

    public enum RBGKeyboardSpeed
    {
        [Display(Name = "Очень медленный")]
        Slowest,
        [Display(Name = "Медленный")]
        Slow,
        [Display(Name = "Быстрый")]
        Fast,
        [Display(Name = "Очень быстрый")]
        Fastest,
    }

    public enum SoftwareStatus
    {
        [Display(Name = "Запущено")]
        Enabled,
        [Display(Name = "Отключено")]
        Disabled,
        [Display(Name = "Не найдено")]
        NotFound,
    }

    public enum SpecialKey
    {
        Unknown = 0,
        Fn_F9 = 1,
        Fn_LockOn = 2,
        Fn_LockOff = 3,
        Fn_PrtSc = 4,
        Fn_R = 16
    }

    public enum Theme
    {
        [Display(Name = "Как в системе")]
        System,
        [Display(Name = "Светлая")]
        Light,
        [Display(Name = "Тёмная")]
        Dark,
    }

    public enum TemperatureUnit
    {
        C,
        F,
    }

    public enum TouchpadLockState
    {
        [Display(Name = "ВЫКЛ")]
        Off,
        [Display(Name = "ВКЛ")]
        On,
    }

    public enum WhiteKeyboardBacklightChanged { }

    public enum WhiteKeyboardBacklightState
    {
        [Display(Name = "ВЫКЛЬ")]
        Off,
        [Display(Name = "Низкая")]
        Low,
        [Display(Name = "Высокая")]
        High,
    }

    public enum WinKeyState
    {
        [Display(Name = "ВКЛ")]
        On,
        [Display(Name = "ВЫКЛ")]
        Off,
    }

    public enum WinKeyChanged { }
}
