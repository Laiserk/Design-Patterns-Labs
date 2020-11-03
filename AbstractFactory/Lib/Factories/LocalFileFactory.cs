using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Interfaces;
using System.IO;

namespace Lib.Factories
{
    public class LocalFileFactory : BaseFileFactory
    {
        protected override string[] ReadFile(string path)
        {     
            return File.ReadAllLines(path);
        }
    }
}
