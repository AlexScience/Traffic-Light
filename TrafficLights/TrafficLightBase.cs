namespace Homework_TrafficLight.TrafficLights;

public abstract class TrafficLightBase
{
    protected abstract LinkedList<TrafficLightState> StateMap { get; }
    public TrafficLightState State { get; private set; }
    public int Id { get; }

    protected TrafficLightBase(int id, TrafficLightState initialState, TrafficLightsDispatcher dispatcher)
    {
        Id = id;
        State = initialState;
        dispatcher.SwitchEvent += Switch;
    }

    protected virtual void Switch()
    {
        var currentState = StateMap.Find(State);
        if (currentState == default)
        {
            throw new InvalidOperationException("неизвестное состояние светофора");
        }

        var nextState = currentState.Next!.Value;
        State = nextState;
        PrintState();
    }

    protected virtual void PrintState()
    {
        Console.WriteLine($"{Id}: {State}");
    }
}