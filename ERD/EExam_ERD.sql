USE [EExamDB]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [nvarchar](128) NOT NULL,
	[first_name] [nvarchar](max) NULL,
	[last_name] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[faculty_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Admins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[id] [nvarchar](128) NOT NULL,
	[name] [nvarchar](max) NULL,
	[faculty_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[id] [nvarchar](128) NOT NULL,
	[name] [nvarchar](max) NULL,
	[University_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Faculties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professors]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[id] [nvarchar](128) NOT NULL,
	[first_name] [nvarchar](max) NULL,
	[last_name] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[dept_id] [nvarchar](128) NULL,
	[faculty_id] [nvarchar](128) NULL,
	[university_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Professors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[id] [nvarchar](128) NOT NULL,
	[questionContent] [nvarchar](max) NULL,
	[isMCQ] [bit] NOT NULL,
	[choice1] [nvarchar](max) NULL,
	[choice2] [nvarchar](max) NULL,
	[choice3] [nvarchar](max) NULL,
	[choice4] [nvarchar](max) NULL,
	[answer] [nvarchar](max) NULL,
	[subjectExam_id] [nvarchar](128) NULL,
	[Professor_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [nvarchar](128) NOT NULL,
	[first_name] [nvarchar](max) NULL,
	[last_name] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[level] [int] NOT NULL,
	[dept_id] [nvarchar](128) NULL,
	[faculty_id] [nvarchar](128) NULL,
	[university_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectExams]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectExams](
	[id] [nvarchar](128) NOT NULL,
	[name] [nvarchar](max) NULL,
	[level] [int] NOT NULL,
	[time_mins] [int] NOT NULL,
	[dept_id] [nvarchar](128) NULL,
	[profosser_id] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.SubjectExams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Universities]    Script Date: 08/03/2020 11:55:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[id] [nvarchar](128) NOT NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Universities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Admins_dbo.Faculties_faculty_id] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_dbo.Admins_dbo.Faculties_faculty_id]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Departments_dbo.Faculties_faculty_id] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_dbo.Departments_dbo.Faculties_faculty_id]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Faculties_dbo.Universities_University_id] FOREIGN KEY([University_id])
REFERENCES [dbo].[Universities] ([id])
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [FK_dbo.Faculties_dbo.Universities_University_id]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Professors_dbo.Departments_dept_id] FOREIGN KEY([dept_id])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_dbo.Professors_dbo.Departments_dept_id]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Professors_dbo.Faculties_faculty_id] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_dbo.Professors_dbo.Faculties_faculty_id]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Professors_dbo.Universities_university_id] FOREIGN KEY([university_id])
REFERENCES [dbo].[Universities] ([id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_dbo.Professors_dbo.Universities_university_id]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Questions_dbo.Professors_Professor_id] FOREIGN KEY([Professor_id])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_dbo.Questions_dbo.Professors_Professor_id]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Questions_dbo.SubjectExams_subjectExam_id] FOREIGN KEY([subjectExam_id])
REFERENCES [dbo].[SubjectExams] ([id])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_dbo.Questions_dbo.SubjectExams_subjectExam_id]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Students_dbo.Departments_dept_id] FOREIGN KEY([dept_id])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_dbo.Students_dbo.Departments_dept_id]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Students_dbo.Faculties_faculty_id] FOREIGN KEY([faculty_id])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_dbo.Students_dbo.Faculties_faculty_id]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Students_dbo.Universities_university_id] FOREIGN KEY([university_id])
REFERENCES [dbo].[Universities] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_dbo.Students_dbo.Universities_university_id]
GO
ALTER TABLE [dbo].[SubjectExams]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SubjectExams_dbo.Departments_dept_id] FOREIGN KEY([dept_id])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[SubjectExams] CHECK CONSTRAINT [FK_dbo.SubjectExams_dbo.Departments_dept_id]
GO
ALTER TABLE [dbo].[SubjectExams]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SubjectExams_dbo.Professors_profosser_id] FOREIGN KEY([profosser_id])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[SubjectExams] CHECK CONSTRAINT [FK_dbo.SubjectExams_dbo.Professors_profosser_id]
GO
