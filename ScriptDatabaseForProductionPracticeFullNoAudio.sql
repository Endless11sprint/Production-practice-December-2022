USE [EducationalPractice]
GO
/****** Object:  Table [dbo].[CategoriesOfWords]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesOfWords](
	[idCategoriesOfWords(pk)] [int] IDENTITY(1,1) NOT NULL,
	[Categorie] [nchar](200) NOT NULL,
 CONSTRAINT [PK_CategoriesOfWords] PRIMARY KEY CLUSTERED 
(
	[idCategoriesOfWords(pk)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnglishWord]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnglishWord](
	[idEnglishWord(pk)] [int] IDENTITY(1,1) NOT NULL,
	[idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)] [int] NULL,
	[Word] [nchar](100) NOT NULL,
 CONSTRAINT [PK_EnglishWord] PRIMARY KEY CLUSTERED 
(
	[idEnglishWord(pk)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian](
	[EnglishWordAndTranslationOfEnglishWordIntoRussian] [int] IDENTITY(1,1) NOT NULL,
	[idEnglishWord(fk)] [int] NOT NULL,
	[idTranslationOfEnglishWordIntoRussian(fk)] [int] NOT NULL,
 CONSTRAINT [PK_EnglishWordAndTranslationOfEnglishWordIntoRussian] PRIMARY KEY CLUSTERED 
(
	[EnglishWordAndTranslationOfEnglishWordIntoRussian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords](
	[idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)] [int] IDENTITY(1,1) NOT NULL,
	[EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)] [int] NOT NULL,
	[idCategoriesOfWords(fk)] [int] NOT NULL,
 CONSTRAINT [PK_EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] PRIMARY KEY CLUSTERED 
(
	[idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PathsToVoiceFilesThatWereCreatedByTheUser]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PathsToVoiceFilesThatWereCreatedByTheUser](
	[idPathsToVoiceFilesThatWereCreatedByTheUser(pk)] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nchar](1000) NOT NULL,
 CONSTRAINT [PK_PathsToVoiceFilesThatWereCreatedByTheUser] PRIMARY KEY CLUSTERED 
(
	[idPathsToVoiceFilesThatWereCreatedByTheUser(pk)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TranslationOfEnglishWordIntoRussian]    Script Date: 15.12.2022 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TranslationOfEnglishWordIntoRussian](
	[idTranslationOfEnglishWordIntoRussian(pk)] [int] IDENTITY(1,1) NOT NULL,
	[MeaningOfTheWordInRussian] [nchar](100) NOT NULL,
 CONSTRAINT [PK_TranslationOfEnglishWordIntoRussian] PRIMARY KEY CLUSTERED 
(
	[idTranslationOfEnglishWordIntoRussian(pk)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoriesOfWords] ON 

INSERT [dbo].[CategoriesOfWords] ([idCategoriesOfWords(pk)], [Categorie]) VALUES (1, N'Биология                                                                                                                                                                                                ')
INSERT [dbo].[CategoriesOfWords] ([idCategoriesOfWords(pk)], [Categorie]) VALUES (2, N'Программирование                                                                                                                                                                                        ')
SET IDENTITY_INSERT [dbo].[CategoriesOfWords] OFF
GO
SET IDENTITY_INSERT [dbo].[EnglishWord] ON 

INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (1, NULL, N'class                                                                                               ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (2, NULL, N'variable                                                                                            ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (3, NULL, N'example                                                                                             ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (4, NULL, N'folder                                                                                              ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (5, NULL, N'property                                                                                            ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (6, NULL, N'versatile                                                                                           ')
INSERT [dbo].[EnglishWord] ([idEnglishWord(pk)], [idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)], [Word]) VALUES (7, NULL, N'maintenance                                                                                         ')
SET IDENTITY_INSERT [dbo].[EnglishWord] OFF
GO
SET IDENTITY_INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ON 

INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (2, 1, 1)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (3, 2, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (4, 3, 3)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (5, 4, 4)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (6, 5, 5)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (7, 6, 6)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian], [idEnglishWord(fk)], [idTranslationOfEnglishWordIntoRussian(fk)]) VALUES (8, 6, 7)
SET IDENTITY_INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] OFF
GO
SET IDENTITY_INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ON 

INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (1, 2, 1)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (2, 2, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (3, 3, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (4, 4, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (5, 5, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (6, 6, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (7, 7, 2)
INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] ([idEnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords(pk)], [EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)], [idCategoriesOfWords(fk)]) VALUES (8, 8, 2)
SET IDENTITY_INSERT [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] OFF
GO
SET IDENTITY_INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ON 

INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (1, N'класс                                                                                               ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (2, N'переменная                                                                                          ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (3, N'пример                                                                                              ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (4, N'папка                                                                                               ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (5, N'свойство                                                                                            ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (6, N'универсальный                                                                                       ')
INSERT [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)], [MeaningOfTheWordInRussian]) VALUES (7, N'многофункциональный                                                                                 ')
SET IDENTITY_INSERT [dbo].[TranslationOfEnglishWordIntoRussian] OFF
GO
ALTER TABLE [dbo].[EnglishWord]  WITH CHECK ADD  CONSTRAINT [FK_EnglishWord_PathsToVoiceFilesThatWereCreatedByTheUser] FOREIGN KEY([idPathsToVoiceFilesThatWereCreatedByTheUserEnglishWord(fk)])
REFERENCES [dbo].[PathsToVoiceFilesThatWereCreatedByTheUser] ([idPathsToVoiceFilesThatWereCreatedByTheUser(pk)])
GO
ALTER TABLE [dbo].[EnglishWord] CHECK CONSTRAINT [FK_EnglishWord_PathsToVoiceFilesThatWereCreatedByTheUser]
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian]  WITH CHECK ADD  CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussian_EnglishWord] FOREIGN KEY([idEnglishWord(fk)])
REFERENCES [dbo].[EnglishWord] ([idEnglishWord(pk)])
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] CHECK CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussian_EnglishWord]
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian]  WITH CHECK ADD  CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussian_TranslationOfEnglishWordIntoRussian] FOREIGN KEY([idTranslationOfEnglishWordIntoRussian(fk)])
REFERENCES [dbo].[TranslationOfEnglishWordIntoRussian] ([idTranslationOfEnglishWordIntoRussian(pk)])
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] CHECK CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussian_TranslationOfEnglishWordIntoRussian]
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords]  WITH CHECK ADD  CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords_CategoriesOfWords] FOREIGN KEY([idCategoriesOfWords(fk)])
REFERENCES [dbo].[CategoriesOfWords] ([idCategoriesOfWords(pk)])
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] CHECK CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords_CategoriesOfWords]
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords]  WITH CHECK ADD  CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords_EnglishWordAndTranslationOfEnglishWordIntoRussian] FOREIGN KEY([EnglishWordAndTranslationOfEnglishWordIntoRussian(fk)])
REFERENCES [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussian] ([EnglishWordAndTranslationOfEnglishWordIntoRussian])
GO
ALTER TABLE [dbo].[EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords] CHECK CONSTRAINT [FK_EnglishWordAndTranslationOfEnglishWordIntoRussianAndCategoriesOfWords_EnglishWordAndTranslationOfEnglishWordIntoRussian]
GO
