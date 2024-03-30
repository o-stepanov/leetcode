using System.Threading;

public class Foo 
{
    private ManualResetEvent mutexThrS = new ManualResetEvent(false);
    private ManualResetEvent mutexThrT = new ManualResetEvent(false);

    public Foo() 
    {    
    }

    public void First(Action printFirst) 
    {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        mutexThrS.Set();
    }

    public void Second(Action printSecond) 
    {
        mutexThrS.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        mutexThrT.Set();
    }

    public void Third(Action printThird) 
    {
        mutexThrT.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}