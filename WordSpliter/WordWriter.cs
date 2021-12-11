using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace WordSpliter
{
    class WordWriter
    {
        private StreamWriter sw;
               
         public void SetSource(string filepath)
         {
            sw = new StreamWriter(filepath, true);
         }
        //Write results for word
        public void Write(string line)
        {
            sw.WriteLine(line);
        }
        //close current StreamWriter
        public void TearDown()
        {
            sw.Close();
        }

    }
}
