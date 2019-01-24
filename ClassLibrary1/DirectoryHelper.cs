using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class DirectoryHelper
    {
	    public static string ExecutingAssemblyDirectory
	    {
		    get
		    {
			    var codeBase = Assembly.GetExecutingAssembly().CodeBase;
			    var uri = new UriBuilder(codeBase);
			    var path = Uri.UnescapeDataString(uri.Path);
			    return Path.GetDirectoryName(path);
		    }
	    }
    }
}
