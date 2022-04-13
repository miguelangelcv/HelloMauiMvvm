using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMauiMvvm.Services
{
    public class SampleService : ISampleService
    {
        private readonly List<string> _strings = new() { 
            "Python", ".NET", "Android", "iOS", "C/C++", "Web", "Mobile"
        };

        public string GetRandomString()
        {
            Random random = new();
            int index = random.Next(_strings.Count);

            return _strings[index];
        }

        public IEnumerable<string> GetSampleStrings() => _strings;
    }
}