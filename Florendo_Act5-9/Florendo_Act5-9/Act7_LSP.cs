using System;

namespace Florendo_Act5_9
{
    internal class Act7_LSP
    {
        internal static void Run()
        {
            Bird eagle = new Eagle();
            Bird penguin = new Penguin();

            eagle.Move();
            penguin.Move();
        }
    }

    public abstract class Bird
    {
        public abstract void Move();
    }

    public class Eagle : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Eagle is flying.");
        }
    }

    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }
}
