// Services/EventService.cs
using System.Collections.Generic;
using System.Linq;

public class EventService
{
    private List<Event> events = new();

    public List<Event> GetEvents() => events;

    public Event GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);

    public void AddEvent(Event newEvent)
    {
        newEvent.Id = events.Count > 0 ? events.Max(e => e.Id) + 1 : 1;
        events.Add(newEvent);
    }

    public void LikeEvent(int id)
    {
        var e = GetEventById(id);
        if (e != null) e.Likes++;
    }
}
