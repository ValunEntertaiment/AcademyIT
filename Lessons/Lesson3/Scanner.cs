using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lessons.Lesson3
{
    class Scanner
    {
        
        string OriginalString;
        DataObject[] dataObjects;

        /// <summary>
        /// Удаляет все не знаки препинания. 
        /// Разделяет предложение на массив и оставляет слова с уникальнымы буквами на конце.
        /// </summary>
        /// <param name="str">Предложение в котором необходимо отсеить слова с повторяющимися буквами на конце</param>
        /// <returns>Массив слов на коне которых буквы не повторяются</returns>
        public string[] Spliter(string str)
        {
            OriginalString = str;
            Regex regex = new Regex(@"\W");
            str = regex.Replace(str, " ");

            regex = new Regex(@"\s+");
            str = regex.Replace(str, " ");
            

            string[] Words = str.Split(' ');
            string[] UniqueWords = new string[Words.Length];
            int index = 0;

            foreach (var item in Words)
            {
                int Count = 0;
                foreach (var SeconItem in UniqueWords)
                {
                    if (SeconItem != null)
                        if (item.Last() == SeconItem.Last())
                            Count++;
                }
                if (Count == 0)
                {
                    UniqueWords[index] = item;
                    index++;
                }
            }
            CharacterRecorder(UniqueWords);
            return UniqueWords;
        }

        /// <summary>
        /// Записывает посление символы уникальных слов в массив данных
        /// </summary>
        /// <param name="UniqueWords">Массив слов с уникальными буквами на конце</param>
        void CharacterRecorder(string[] UniqueWords)
        {
            dataObjects = new DataObject[UniqueWords.Length];
            for (int i = 0; i < UniqueWords.Length; i++)
            {
                dataObjects[i] = new DataObject();
                if(UniqueWords[i] != null)
                    dataObjects[i].Сharacter = UniqueWords[i].Last();
            }
        }

        /// <summary>
        /// Записывает долю букв в массив данных
        /// </summary>
        /// <returns>Массив данных</returns>
        public DataObject[] StatsRecorder()
        {
            foreach (var DataObject in dataObjects)
            {
                double sum = 0;
                if(DataObject.Сharacter != '\0')
                    foreach (var Character in OriginalString)
                    {
                        if (Character == DataObject.Сharacter)
                            sum++;
                    }
                DataObject.Percent =  sum / Convert.ToDouble(OriginalString.Length) * 100d;
            }
            return dataObjects;
        }

    }
}

