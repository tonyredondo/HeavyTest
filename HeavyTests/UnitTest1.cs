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
    public void HeavyTest()
    {
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Task.Run(() => Proc());
        Proc();
    }
    
    private void Proc()
    {
        // Test
        for (var x = 0; x < 60000; x++)
        {
            for (var i = 0; i < 1_000_000; i++)
            {
                var a = 1000;
                var b = 2000;
                var k = Math.Sqrt(Math.Sin(a) * Math.Cos(b)) + i;
            }
        }
    }
}