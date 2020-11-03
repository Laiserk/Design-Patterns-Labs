using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Interfaces;
using System.Net;
using System.IO;

namespace Lib.Factories
{
    public class RemoteFileFactory : BaseFileFactory
    {
        protected override string[] ReadFile(string url)
        {
            var webRequest = WebRequest.Create(url);

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                return strContent.Split('\n');
            }
        }
    }
}
