﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskNumberThree
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EducationalPracticeEntities : DbContext
    {
        public EducationalPracticeEntities()
            : base("name=EducationalPracticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoriesOfWords> CategoriesOfWords { get; set; }
        public virtual DbSet<EnglishWord> EnglishWord { get; set; }
        public virtual DbSet<EnglishWordAndTranslationOfEnglishWordIntoRussian> EnglishWordAndTranslationOfEnglishWordIntoRussian { get; set; }
        public virtual DbSet<EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords> EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords { get; set; }
        public virtual DbSet<PathsToVoiceFilesThatWereCreatedByTheUser> PathsToVoiceFilesThatWereCreatedByTheUser { get; set; }
        public virtual DbSet<TranslationOfEnglishWordIntoRussian> TranslationOfEnglishWordIntoRussian { get; set; }
    }
}