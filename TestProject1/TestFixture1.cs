using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit.Framework;

namespace TestProject1
{
	[TestFixture]
    public class TestFixture1
    {
	    [Test]
	    public void VerifyExecutingAssemblyDirectory1()
	    {
			StringAssert.Contains(@"TestProject1\TestProject1\bin\Debug", DirectoryHelper.ExecutingAssemblyDirectory);
	    }
    }
}
