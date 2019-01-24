using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit.Framework;

namespace TestProject2
{
	[TestFixture]
    public class TestFixture2
    {
	    [Test]
	    public void VerifyExecutingAssemblyDirectory2()
	    {
		    StringAssert.Contains(@"\TestProject2\bin\Debug", DirectoryHelper.ExecutingAssemblyDirectory);
	    }
	}
}
