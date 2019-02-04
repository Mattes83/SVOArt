using System.Collections.Generic;
using SVOArt.Models;

namespace SVOArt.Repository
{
    internal interface ISentenceRepository
    {
        List<Sentence> LoadSentences();

        void SaveSentences(List<Sentence> sentences);
    }
}