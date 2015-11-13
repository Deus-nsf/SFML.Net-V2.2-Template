using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.IO;

/****************************************************************
File		:  EntryPoint.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Serves as Starting Object for our program, our 'main' is located here.
******************************************************************/

namespace Template
{
	class EntryPoint
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool SetDllDirectory(string lpPathName);

		static void Main(string[] _arguments)
		{
			SetDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SFML_ExternalLibs"));
			SFMLConfig.MyConfig();
		}
	}
}