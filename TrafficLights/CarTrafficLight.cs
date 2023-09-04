namespace Homework_TrafficLight.TrafficLights;

public class CarTrafficLight : TrafficLightBase
{
    protected override LinkedList<TrafficLightState> StateMap { get; }

    public CarTrafficLight(int id, TrafficLightState initialState, TrafficLightsDispatcher dispatcher)
        : base(id, initialState, dispatcher)
    {
        StateMap = new LinkedList<TrafficLightState>(new[]
        {
            TrafficLightState.Allowed,
            TrafficLightState.Prohibited
        });
    }
}