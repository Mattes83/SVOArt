using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SVOArt;
using SVOArt.Models;
using SVOArt.Repository;

namespace SVOArtTest
{
    [TestClass]
    public class MainWindowViewModelTest
    {
        [TestMethod]
        public void LogsExceptionOnErrorWhenSaving()
        {
            var repoMock = GetRepoMock();
            var loggerMock = new Mock<SVOArt.Logger.ILogger>();
            var viewModel = new MainWindowViewModel(repoMock.Object, loggerMock.Object);

            viewModel.SaveCommand.Execute(null);

            loggerMock.Verify(mock => mock.LogException(It.IsAny<Exception>(), It.IsAny<string>()), Times.Once());
        }

        private Mock<ISentenceRepository> GetRepoMock()
        {
            var repoMock = new Mock<ISentenceRepository>();
            repoMock.Setup(r => r.SaveSentences(It.IsAny<List<Sentence>>())).Throws<RepositoryException>();
            repoMock.Setup(r => r.LoadSentences()).Returns(new List<Sentence>());

            return repoMock;
        }
    }
}
