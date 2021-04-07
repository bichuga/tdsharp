// /*
// MIT LICENSE
// 
// Copyright 2018 Digital Ruby, LLC - http://www.digitalruby.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// */

namespace ShillCollector
{
    using System.IO.Abstractions;

    using Newtonsoft.Json;

    using TDLib.Samples.GetChats.Model;

    public class StateLoader : IStateLoader
    {
        public const string ShillsFileName = "shills.json";

        private readonly IFileSystem fileSystem;

        public StateLoader(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public ShillCollection Load()
        {
            ShillCollection sc = new ShillCollection();
            if (this.fileSystem.File.Exists(ShillsFileName))
            {
                sc = JsonConvert.DeserializeObject<ShillCollection>(this.fileSystem.File.ReadAllText(ShillsFileName));
            }

            return sc;
        }
    }
}