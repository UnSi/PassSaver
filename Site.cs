using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PassSaver
{
    class Site
    {
		public string siteName;
		private static int siteCount;
		public Site()
		{
			siteCount++;
		}
		public Site(String siteName){
			this.siteName = siteName;
			siteCount++;
		}
		public String Length()
		{
			return Site.siteCount;
		}
		public String toString(){
			return siteName;
		}
				
		class Login{
			public string siteLogin;
		}
    }
}