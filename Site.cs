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
        private static List<String> siteList;

        public Site(String siteName) {
            siteList.Add(siteName);
            this.siteName = siteName;
        }

        public void removeSite(int index)
        {
            siteList.RemoveAt(index);
        }
        public List<String> getSiteList()
        {
            return siteList;
        }
        public void addLogin(String loginName)
        {
            Login login = new Login(loginName);
        }
        public String Length(){return siteList.Count;}
        public String toString(){return siteName;}

        class Login
        {
            private static List<String> loginList;
            public string loginName;

            public Login(String loginName)
            {
                loginList.Add(loginName);
                this.loginName = loginName;
            }

            public void removeLogin(int index)
            {
                loginList.RemoveAt(index);
            }
            public String Length() { return loginList.Count; }
            public String toString() { return lo; }
        }
    }
}