using SVOArt.Logger;
using SVOArt.Models;
using SVOArt.Repository;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Input;

namespace SVOArt
{
    [Export(typeof(MainWindowViewModel))]
    internal class MainWindowViewModel
    {
        private readonly ISentenceRepository _repository;
        private readonly ILogger _logger;

        [ImportingConstructor]
        public MainWindowViewModel(ISentenceRepository repo, ILogger logger)
        {
            _repository = repo;
            _logger = logger;
            SaveCommand = new RelayCommand(OnSave);
            OnLoad();
        }

        public List<Sentence> Sentences { get; private set; }
        public ICommand SaveCommand { get; set; }

        private void OnSave()
        {
            try
            {
                _repository.SaveSentences(Sentences);
            }
            catch (RepositoryException ex)
            {
                _logger.LogException(ex, "Sentences could not be saved");
                Application.Current?.Shutdown();
            }
        }

        private void OnLoad()
        {
            try
            {
                Sentences = _repository.LoadSentences();
            }
            catch (RepositoryException ex)
            {
                _logger.LogException(ex, "Sentences could not be loaded");
                Application.Current.Shutdown();
            }
        }
    }
}