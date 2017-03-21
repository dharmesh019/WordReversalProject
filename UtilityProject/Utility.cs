using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityProject
{
    public  static class Utility
    {

      static  string[] getWordsOfSentences(string Sentence)
        {
          return  Sentence.Split(' ');
        }
    }
}
