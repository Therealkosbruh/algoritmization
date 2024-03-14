CREATE TABLE [dbo].[comp](
	[act_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[event_id] [int] NULL,
	[act_id1] [int] NULL,
	[day_number] [int] NULL,
	[day_qty] [int] NULL,
	[jury_team][int] NOT NULL,
	[date_of_beggining] [date] NULL,
	[time_of_beggining] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[counties]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[counties](
	[country_id] [int] IDENTITY(1,1) NOT NULL,
	[country_name] [varchar](20) NULL,
	[eng_country_name] [varchar](20) NULL,
	[cod] [varchar](4) NULL,
	[cod2] [varchar](4) NULL,
 )
GO
/****** Object:  Table [dbo].[events]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[events](
	[event_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[event_name] [varchar](90) NOT NULL,
	[Date] [date] NOT NULL,
	[Days] [int] NOT NULL,
	[City] [int] NOT NULL,
 CONSTRAINT [PK_events] PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jury_on_comp]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jury_on_comp](
	[comid] [int] NOT NULL,
	[juryteam] [int] NOT NULL
	CONSTRAINT [jury_on_comp] PRIMARY KEY CLUSTERED (comid ASC, juryteam ASC))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jury_teams]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jury_teams](
	
	[team_id] [int] PRIMARY KEY NOT NULL,
	[team_members] [int] NOT NULL,
 CONSTRAINT [PK_jury_teams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kind_of_trend]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kind_of_trend](
	[kot_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[kot] [varchar](55) NULL,
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[main_table]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[main_table](
	[comp_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NOT NULL,
	[comp_name] [int] NULL,
	[moder] [int] NULL,
	[winner] [int] NULL,
 )
GO
/****** Object:  Table [dbo].[moder_teams]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[moder_teams](
	[team_id] [int]  PRIMARY KEY NOT NULL,
	[moder_members] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[renders]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[Gender] [int] NOT NULL,
	[Gender_name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_renders_1] PRIMARY KEY CLUSTERED 
(
	[Gender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] NOT NULL,
	[role_name] [nvarchar](255) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trends]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trends](
	[trend_id] [int]  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[trend_name] [varchar](50) NULL,
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 27.12.2023 21:36:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[User_id] [int]  IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[role_id] [int] NULL,
	[FIO] [varchar](50) NULL,
	[gender] [int] NULL,
	[dob] [date] NULL,
	[country] [int] NULL,
	[phone] [varchar](25) NULL,
	[password] [varchar](15) NULL,
	[photo] [nvarchar](255) NULL,
	[mail] [varchar](25) NULL,
	[kind_of_trends] [int] NULL,
	[trend] [int] NULL,
	)
	

--keys--
	alter table users
	ADD FOREIGN KEY(role_id) REFERENCES roles(role_id);
	ADD FOREIGN KEY(gender) REFERENCES Genders(gender_id);
	ADD FOREIGN KEY(country) REFERENCES countries(country_id);

	alter table moder_teams
	ADD FOREIGN KEY(moder_members) REFERENCES users(User_id);

	alter table jury_teams
	ADD FOREIGN KEY(team_members) REFERENCES users(User_id);

	alter table jury_on_comp
	ADD FOREIGN KEY(juryteam) REFERENCES jury_team(team_id);
	ADD FOREIGN KEY(comid) REFERENCES comp(act_id);


	alter table events
	ADD FOREIGN KEY(city) REFERENCES cities(city_id);

	ALTER TABLE  CONSTRAINT FK_jury_on_comp FOREIGN KEY (jury_team) REFERENCES jury_on_comp (comid);