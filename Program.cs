using Homework_TrafficLight.TrafficLights;

using var trafficLightsDispatcher = new TrafficLightsDispatcher(TimeSpan.FromSeconds(3));
_ = new CarTrafficLight(1, TrafficLightState.Allowed, trafficLightsDispatcher);
_ = new CarTrafficLight(2, TrafficLightState.Prohibited, trafficLightsDispatcher);
Console.ReadLine();