namespace HeavyTests;

public class UnitTest1
{
    [Fact]
    public void EmptyTest01()
    {
    }
    
    [Fact]
    public void EmptyTest02()
    {
    }
    
    [Fact]
    public void EmptyTest03()
    {
    }
    
    [Fact]
    public void EmptyTest04()
    {
    }
    
    [Fact]
    public void EmptyTest05()
    {
    }
    
    [Fact]
    public void EmptyTest06()
    {
    }
    
    [Fact]
    public void EmptyTest07()
    {
    }
    
    [Fact]
    public void EmptyTest08()
    {
    }
    
    [Fact]
    public void EmptyTest09()
    {
    }
    
    [Fact]
    public void EmptyTest10()
    {
    }
    
    [Fact]
    public void HeavyTest()
    {
        var tsk1 = Task.Run(() => Proc());
        var tsk2 = Task.Run(() => Proc());
        var tsk3 = Task.Run(() => Proc());
        var tsk4 = Task.Run(() => Proc());
        var tsk5 = Task.Run(() => Proc());
        var tsk6 = Task.Run(() => Proc());
        var tsk7 = Task.Run(() => Proc());
        var tsk8 = Task.Run(() => Proc());
        var tsk9 = Task.Run(() => Proc());
        var tsk10 = Task.Run(() => Proc());

        Task.WaitAll(tsk1, tsk2, tsk3, tsk4, tsk5, tsk6, tsk7, tsk8, tsk9, tsk10);
    }
    
    private void Proc()
    {
        for (var x = 0; x < 600; x++)
        {
            for (var i = 0; i < 120; i++)
            {
                var a = 1000;
                var b = 2000;
                var k = Math.Sqrt(Math.Sin(a) * Math.Cos(b)) + i;
            }
        }
    }
}
