using System;
namespace Composition
{
    public class Window
    {

    }
    public class CompositionWall : Window
    {
        private Window window;

        public Wall()
        {
            this.window=new Window();
        }
    }
}
