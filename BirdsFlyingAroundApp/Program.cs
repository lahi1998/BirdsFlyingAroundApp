using BirdsFlyingAroundApp;



Main main = new Main();

Thread t = new Thread(main.RunPenguin);
t.Name = "Producer";
t.Priority = ThreadPriority.Normal;
t.Start();

t.Join();

public class Main
{

    public void RunDuck()
    {
        Duck d = new Duck(100);
        while (true)
        {
            d.Fly();
            d.Diving();
            d.Walk();
            d.Sound();
        }
    }

    public void RunOwl()
    {
        Owl o = new Owl(100);
        while (true)
        {
            o.Fly();
            o.Walk();
            o.Sound();
        }
    }

    public void RunPenguin()
    {
        Penguin p = new Penguin(100);
        while (true)
        {
            p.Diving();
            p.Walk();
            p.Sound();
        }
    }
    public void RunSeagull()
    {
        Seagull s = new Seagull(100);
        while (true)
        {
            s.Fly();
            s.Walk();
            s.Sound();
        }
    }
}