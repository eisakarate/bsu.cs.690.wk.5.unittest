namespace AtmService.Test;

using AtmServices;

public class AtmTests
{
    atm testAtm;
    int initialBalance = 100;

    public AtmTests()
    {
        testAtm = new atm(initialBalance = initialBalance);
    }


    [Fact]
    public void TestWithdraw()
    {
        var res = testAtm.withdrwal(25);

        Assert.True(res);
        
        Assert.Equal(75, testAtm.getBalance());
    }

    [Fact]
    public void TestWithdraw_Failure()
    {
        var res = testAtm.withdrwal(125);
        Assert.False(res);
        Assert.Equal(100, testAtm.getBalance());
    }
    [Fact]
    public void TestWithdraw_SanityCheck()
    {
        var res = testAtm.withdrwal(40);
        Assert.True(res);
        res = testAtm.deposit(40);
        Assert.True(res);
        Assert.Equal(100, testAtm.getBalance());
    }
}