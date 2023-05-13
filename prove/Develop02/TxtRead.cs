using System;

public class TxtRead 
{
    public List<Entry> _entries = new List<Entry>();
    public void Displaytexts()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        
    }
}