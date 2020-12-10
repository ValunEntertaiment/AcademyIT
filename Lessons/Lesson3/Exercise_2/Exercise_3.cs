using System;
using System.Text.RegularExpressions;

namespace Lessons.Lesson3
{
    class Exercise_3
    {

        public Regex GetRegexIP()
        {
            return new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
        }

        public Regex GetRegexMail()
        {
            return new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        }
    }
}
