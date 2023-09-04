namespace Homework_TrafficLight.TrafficLights;

public sealed class TrafficLightsDispatcher : IDisposable
{
    private System.Timers.Timer _timer = new();

    public delegate void SwitchDelegate();

    public event SwitchDelegate? SwitchEvent;

    public TrafficLightsDispatcher(TimeSpan period)
    {
        _timer.AutoReset = true;
        _timer.Elapsed += (_, _) => SwitchEvent?.Invoke();
        _timer.Interval = period.TotalMilliseconds;
        _timer.Enabled = true;
    }

    public void Dispose()
    {
        _timer.Dispose();
    }
}