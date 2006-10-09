//
// DataSourceSelectArgumentsTest.cs - unit tests for System.Web.UI.DataSourceSelectArguments
//
// Author:
//	Igor Zelmanovich  <igorz@mainsoft.com>
//
// Copyright (C) 2006 Mainsoft, Inc (http://www.mainsoft.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if NET_2_0

using NUnit.Framework;

using System;
using System.IO;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;

namespace MonoCasTests.System.Web.UI
{

	[TestFixture]
	public class DataSourceSelectArgumentsTest
	{

		[Test]
		public void Equals ()
		{
			DataSourceSelectArguments arg1 = new DataSourceSelectArguments ();
			DataSourceSelectArguments arg2 = DataSourceSelectArguments.Empty;

			Assert.IsTrue (arg1.Equals (arg2), "Equals#1");
			Assert.IsTrue (arg1.GetHashCode () == arg2.GetHashCode (), "GetHashCode#1");

			arg1.SortExpression = "sort";
			arg1.MaximumRows = 10;
			arg1.StartRowIndex = 5;
			arg1.RetrieveTotalRowCount = true;
			arg1.TotalRowCount = 30;

			Assert.IsFalse (arg1.Equals (arg2), "Equals#2");
			Assert.IsFalse (arg1.GetHashCode () == arg2.GetHashCode (), "GetHashCode#2");

			arg2.SortExpression = "sort";
			arg2.MaximumRows = 10;
			arg2.StartRowIndex = 5;

			Assert.IsFalse (arg1.Equals (arg2), "Equals#3");
			Assert.IsFalse (arg1.GetHashCode () == arg2.GetHashCode (), "GetHashCode#3");

			arg2.RetrieveTotalRowCount = true;
			arg2.TotalRowCount = 30;

			Assert.IsTrue (arg1.Equals (arg2), "Equals#4");
			Assert.IsTrue (arg1.GetHashCode () == arg2.GetHashCode (), "GetHashCode#4");
		}
	}
}
#endif
