using System.Threading.Tasks;
public class Foo {

    private TaskCompletionSource _f;
    private TaskCompletionSource _s;

    public Foo() {
        _f = new TaskCompletionSource();
        _s = new TaskCompletionSource();
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _f.SetResult();
    }

    public void Second(Action printSecond) {
        
        // printSecond() outputs "second". Do not change or remove this line.
        _f.Task.Wait();
        printSecond();
        _s.SetResult();

    }

    public void Third(Action printThird) {
        
        // printThird() outputs "third". Do not change or remove this line.
        _s.Task.Wait();
        printThird();
    }
}