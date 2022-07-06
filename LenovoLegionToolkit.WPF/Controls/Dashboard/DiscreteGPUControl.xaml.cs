using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Controllers;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public partial class DiscreteGPUControl
    {
        private readonly GPUController _gpuController = IoCContainer.Resolve<GPUController>();

        public DiscreteGPUControl()
        {
            InitializeComponent();

            _gpuController.Refreshed += GpuController_Refreshed;

            IsVisibleChanged += DiscreteGPUControl_IsVisibleChanged;
        }

        protected override void OnFinishedLoading() { }

        protected override async Task OnRefreshAsync()
        {
            if (!_gpuController.IsSupported())
                throw new InvalidOperationException("Неподдерживаемая операция");

            if (!IsVisible)
                return;

            await _gpuController.StartAsync();
        }
        private async void DiscreteGPUControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
                return;

            _content.Visibility = Visibility.Hidden;

            await _gpuController.StopAsync();
        }

        private void GpuController_Refreshed(object? sender, GPUController.RefreshedEventArgs e) => Dispatcher.Invoke(() =>
        {
            var performanceStateText = $"Состояние производительности:\n{e.PerformanceState ?? "Unknown"}";

            if (e.Status == GPUController.Status.Unknown || e.Status == GPUController.Status.NVIDIAGPUNotFound)
            {
                _discreteGPUStatusDescription.Text = "-";
                _discreteGPUStatusDescription.ToolTip = null;
                _discreteGPUStatusActiveIndicator.Visibility = Visibility.Collapsed;
                _discreteGPUStatusInactiveIndicator.Visibility = Visibility.Collapsed;
            }
            else if (e.IsActive)
            {
                var status = "Активен";
                var processes = string.Empty;

                if (e.ProcessCount > 0)
                {
                    status += $" ({e.ProcessCount} приложение{(e.ProcessCount > 1 ? "s" : "")})";
                    processes += "Процессы:";

                    foreach (var p in e.Processes)
                    {
                        try
                        {
                            processes += $"\n · {p.ProcessName}";
                        }
                        catch { }
                    }
                }
                else
                {
                    processes += "Нет процессов";

                }

                _discreteGPUStatusDescription.Text = status;
                _discreteGPUStatusDescription.ToolTip = $"{performanceStateText}\n\n{processes}";
                _discreteGPUStatusActiveIndicator.Visibility = Visibility.Visible;
                _discreteGPUStatusInactiveIndicator.Visibility = Visibility.Collapsed;
            }
            else
            {
                _discreteGPUStatusDescription.Text = "Неактивен";
                _discreteGPUStatusDescription.ToolTip = $"nVidia GPU не работает.\n\n{performanceStateText}";
                _discreteGPUStatusActiveIndicator.Visibility = Visibility.Collapsed;
                _discreteGPUStatusInactiveIndicator.Visibility = Visibility.Visible;
            }

            _deactivateGPUButton.IsEnabled = e.CanBeDeactivated;

            if (e.CanBeDeactivated)
            {
                _deactivateGPUButtonText.SetResourceReference(ForegroundProperty, "TextOnAccentFillColorPrimaryBrush");
                _deactivateGPUButtonIcon.SetResourceReference(ForegroundProperty, "TextOnAccentFillColorPrimaryBrush");
            }
            else
            {
                _deactivateGPUButtonText.SetResourceReference(ForegroundProperty, "TextFillColorDisabledBrush");
                _deactivateGPUButtonIcon.SetResourceReference(ForegroundProperty, "TextFillColorDisabledBrush");
            }

            _deactivateGPUButton.ToolTip = e.Status switch
            {
                GPUController.Status.MonitorsConnected => "Внешний монитор подключен к nVidia GPU.",
                GPUController.Status.DeactivatePossible => "nVidia GPU может быть отключен.\n\nПомните, что некоторые программы в результате могут крашнуться.",
                GPUController.Status.Inactive => "nVidia GPU не активен.",
                _ => null,
            };

            _content.Visibility = Visibility.Visible;
        });

        private void DeactivateGPUButton_Click(object sender, RoutedEventArgs e)
        {
            _deactivateGPUButton.ContextMenu.PlacementTarget = _deactivateGPUButton;
            _deactivateGPUButton.ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            _deactivateGPUButton.ContextMenu.IsOpen = true;
        }

        private async void KillAppsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            _deactivateGPUButton.IsEnabled = false;
            await _gpuController.KillGPUProcessesAsync();
        }

        private async void RestartGPUMenuItem_Click(object sender, RoutedEventArgs e)
        {
            _deactivateGPUButton.IsEnabled = false;
            await _gpuController.DeactivateGPUAsync();
        }
    }
}
