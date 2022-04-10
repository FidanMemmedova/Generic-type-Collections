using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
    class Collection<T>
    {
        public T[] Languages;
        public string LanguageName { get; set; }
        public DateTime LanguageDate { get; set; }
        public Collection(string languageName, DateTime languageDate)
        {
            LanguageName = languageName;
            LanguageDate = languageDate;
        }




}

