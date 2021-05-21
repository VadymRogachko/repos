using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] RUS = new string[5];
        private string[] UA = new string[5];
        private string[] ENG = new string[5];

        public Dictionary()
        {
            RUS[0] = "книга"; UA[0] = "книга"; ENG[0] = "book";
            RUS[1] = "ручка"; UA[1] = "ручка"; ENG[1] = "pen";
            RUS[2] = "солнце"; UA[2] = "сонце"; ENG[2] = "sun";
            RUS[3] = "яблоко"; UA[3] = "яблуко"; ENG[3] = "apple";
            RUS[4] = "стол"; UA[4] = "стіл"; ENG[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < RUS.Length; i++)
                    if (RUS[i] == index)
                        return RUS[i] + " - " + UA[i] + " - " + ENG[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < RUS.Length)
                    return RUS[index] + " - " + UA[index] + " - " + ENG[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
