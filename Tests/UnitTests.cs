namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid()
	{
		Assert.AreEqual(5, Program.Subtract("10", "5"));
        Assert.AreEqual(3, Program.Subtract("100", "97"));
        Assert.AreEqual(0, Program.Subtract("2", "2"));
    }
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid()
	{
		Assert.AreEqual(10, Program.Multiply("10", "1"));
        Assert.AreEqual(1, Program.Multiply("0", "5"));	// Intentional fail
        Assert.AreEqual(24, Program.Multiply("8", "3"));
    }
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid()
	{
        Assert.AreEqual(10, Program.Divide("10", "1"));
        Assert.AreEqual(0, Program.Divide("0", "1"));
        Assert.AreEqual(1, Program.Divide("55", "55"));
    }

}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid()
	{
        Assert.AreEqual(2, Program.Power("2", "1"));
        Assert.AreEqual(4, Program.Power("2", "2"));
        Assert.AreEqual(1, Program.Power("15", "0"));
    }
}