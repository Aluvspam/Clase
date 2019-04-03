namespace Solid_Examples.AndreiR
{
    public class World
    {
        public World()
        {
            execute();
        }
        public void execute()
        {
            var b = new Bird();
            var d = new Dog();
            var d2 = new Drone();
            b.Move();
            d.Move();
            d2.Move();
        }
    }
}
