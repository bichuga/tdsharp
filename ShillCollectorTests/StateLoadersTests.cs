namespace ShillCollectorTests
{
    using System;
    using System.Collections.Generic;
    using System.IO.Abstractions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NSubstitute;

    using ShillCollector;

    [TestClass]
    public class StateLoadersTests
    {
        [TestMethod]
        public void Load_FetchesFileFromDisk()
        {
            var fileSystem = Substitute.For<IFileSystem>();
            fileSystem.File.Exists(null).ReturnsForAnyArgs(true);
            fileSystem.File.ReadAllText("shills.json").Returns(Resources.SingleRecord);

            var sl = new StateLoader(fileSystem);
            sl.Load();

            fileSystem.File.Received(1).Exists(StateLoader.ShillsFileName);
            fileSystem.File.Received(1).ReadAllText(StateLoader.ShillsFileName);
        }
    }
}
