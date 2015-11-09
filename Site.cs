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
        private static List<Site> siteList = new List<Site>();
        private List<Login> loginList = new List<Login>();
		
// Constructor
        public Site(String siteName) {
            this.siteName = siteName;
            siteList.Add(this);
        }
// /Constructor

// Site
        public void removeSite(int index){
            siteList.RemoveAt(index);
        }
        public List<Site> getSiteList(){
            return siteList;
        }
        public int Length(){return siteList.Count;}
        
        public override string ToString(){return siteName;}
		
// Login	
		public void addLogin(String loginName){
			Login login = new Login(loginName,this);
		}
		public void setPass (string password, int loginIndex)		{
			 Login login = loginList[loginIndex];
			 login.setPassword(password);
			 
		}
		public List<Login> getLoginList(){
			return loginList;
		}
		public int loginLength() {
			return this.getLoginList().Count;
		}
		public string loginToString(int index){
			Login login = this.getLoginList()[index];
			return login.ToString();
			}
		public void removeLogin(int index){
            loginList.RemoveAt(index);
		}
		
		
        public class Login{
			
            private string loginName;
			private string Password;
			private string Mail;
            private Site parent;
			
	// Constructor
            public Login(String loginName, Site site){
                this.loginName = loginName;
                parent = site;
               site.loginList.Add(this);
            }
	// /Constructor	
	
            public void removeLogin(int index) {parent.loginList.RemoveAt(index); }
            public int Length() { return parent.loginList.Count; }
            public override string ToString() { return this.loginName; }
			public string getLogin() { return this.loginName; }
			public void setLogin(string login) { this.loginName=login; }
			public string getPassword() { return this.Password; }
			public void setPassword(string password) {this.Password = password; }
			public string getMail() { return this.Mail; }
			public void setMail(string mail) { this.Mail = mail; }
			
        }
    }
}