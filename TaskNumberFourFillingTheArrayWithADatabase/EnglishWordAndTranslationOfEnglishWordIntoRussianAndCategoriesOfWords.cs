//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskNumberFourFillingTheArrayWithADatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords
    {
        public int idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords_pk_ { get; set; }
        public int EnglishWordAndTranslationOfEnglishWordIntoRussian_fk_ { get; set; }
        public int idCategoriesOfWords_fk_ { get; set; }
    
        public virtual CategoriesOfWords CategoriesOfWords { get; set; }
        public virtual EnglishWordAndTranslationOfEnglishWordIntoRussian EnglishWordAndTranslationOfEnglishWordIntoRussian { get; set; }
    }
}
