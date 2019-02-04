using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using Newtonsoft.Json;
using SVOArt.Models;

namespace SVOArt.Repository
{
    [Export(typeof(ISentenceRepository))]
    internal class SentenceRepository : ISentenceRepository
    {
        private const string FilePath = "sentences.json";

        public List<Sentence> LoadSentences()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Sentence>>(File.ReadAllText(FilePath));
            }
            catch (Exception e)
            {
                throw new RepositoryException("Error loading sentences", e);
            }
        }

        public void SaveSentences(List<Sentence> sentences)
        {
            try
            {
                File.WriteAllText(FilePath, JsonConvert.SerializeObject(sentences));
            }
            catch (Exception e)
            {
                throw new RepositoryException("Error saving sentences", e);
            }
        }
    }
}