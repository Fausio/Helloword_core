using System;

namespace Helloword_core
{
    public class Hello : IHello
    {
        public Hello()
        {
            //throw new Exception();
        }
  
        string IHello.SayHello()
        {
            return "Hello fromn class";
        }
    }
}