using System;

namespace ObstaclesClass
{
    abstract class Obstacles
    {
        float resistence;
        float weight;
        float hight;
        public abstract void Block();
        public abstract void Inspect();
    }
    interface IMovable
    {  
        public abstract void Move();
    }

    interface IBreakable
    {
        public abstract void Break();
    }
    interface IJumopable
    {
        public abstract void Jump();
    }


    class Chair : Obstacles, IMovable, IJumopable
    {
        public override void  Block()
        {

        }
        public override void Inspect()
        {

        }
        public  void Move()
        {

        }
        public  void Jump()
        {

        }
    }

    class Wall : Obstacles,IBreakable,IJumopable
    {
        public override void Block()
        {

        }
        public override void Inspect()
        {

        }
        public void Break()
        {
           
        }
        public void Jump()
        {

        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
