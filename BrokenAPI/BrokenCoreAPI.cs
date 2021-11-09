using BrokenAPI.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace BrokenAPI
{
    public class BrokenCoreAPI
    {
        private string XFApiKey = "";
        public BrokenCoreAPI(string key)
        {
            this.XFApiKey = key;
            me = new Me(key);
            resources = new Resources(key);
            users = new Users(key);
            threads = new Threads(key);
        }
        public Me me;
        public Resources resources;
        public Users users;
        public Threads threads;
        public class Threads
        {
            private string XFApiKey = "";
            public Threads(string key)
            {
                this.XFApiKey = key;
            }

            public List<Thread> Get()
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://brokencore.club/api/threads/");
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "BrokenAPI Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Headers.Set("XF-Api-Key", XFApiKey);

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Out);
                return myDeserializedClass.threads;
            }
            private class Root
            {
                public List<Thread> threads { get; set; }
                public Pagination pagination { get; set; }
            }
        }

        public class Users
        {
            private string XFApiKey = "";
            public Users(string key)
            {
                this.XFApiKey = key;
            }

            public Data.User Get(int user)
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://brokencore.club/api/users/" + user);
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "BrokenAPI Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Headers.Set("XF-Api-Key", XFApiKey);

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Out);
                return myDeserializedClass.user;
            }
            private class Root
            {
                public Data.User user { get; set; }
            }
        }
        public class Resources
        {
            private string XFApiKey = "";
            public Resources(string key)
            {
                this.XFApiKey = key;
            }
            public Data.Resource Get(int resource)
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://brokencore.club/api/resources/" + resource);
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "BrokenAPI Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Headers.Set("XF-Api-Key", XFApiKey);

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Out);
                return myDeserializedClass.resource;
            }
            private class Root
            {
                public Data.Resource resource { get; set; }
            }
        }

        public class Me
        {
            private string XFApiKey = "";
            public Me(string key)
            {
                this.XFApiKey = key;
            }
            public Data.Me Get()
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://brokencore.club/api/me");
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.UserAgent = "BrokenAPI Mozilla/5.0 (Windows NT 5.1; rv:5.0) Gecko/20100101 Firefox/5.0";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Headers.Set("XF-Api-Key", XFApiKey);

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                sr.Close();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Out);
                return myDeserializedClass.me;
            }

            private class Root
            {
                public Data.Me me { get; set; }
            }
        }
    }
}
