using System;
using NUnit.Framework;
using ConsoleApp1;

[TestFixture]
public class PlayPassTests
{

    [Test]
    public void Test1()
    {
        Assert.AreEqual("!!!vPz fWpM J", PlayPass.playPass("I LOVE YOU!!!", 1));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO",
            PlayPass.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));
    }

}
