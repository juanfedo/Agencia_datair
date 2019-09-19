USE [datair]
GO

/****** Object:  Table [dbo].[aerolinea]    Script Date: 29/09/2018 8:59:59 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[aerolinea](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
 CONSTRAINT [PK_aerolinea] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [datair]
GO

/****** Object:  Table [dbo].[avion]    Script Date: 29/09/2018 9:00:19 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[avion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](100) NULL,
	[capacidad] [int] NULL,
 CONSTRAINT [PK_avion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [datair]
GO

/****** Object:  Table [dbo].[ciudad]    Script Date: 29/09/2018 9:00:28 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ciudad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_ciudad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [datair]
GO

/****** Object:  Table [dbo].[reservas]    Script Date: 29/09/2018 9:00:37 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[reservas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vuelo_ida_id] [int] NULL,
	[vuelo_regreso_id] [int] NULL,
	[cliente] [varchar](150) NULL,
	[identificacion] [varchar](50) NULL,
	[tipo_tarjeta] [varchar](50) NULL,
	[numero_tarjeta] [varchar](50) NULL,
 CONSTRAINT [PK_reservas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_reservas] FOREIGN KEY([id])
REFERENCES [dbo].[reservas] ([id])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_reservas]
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_vuelo] FOREIGN KEY([vuelo_ida_id])
REFERENCES [dbo].[vuelo] ([id])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_vuelo]
GO

ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [FK_reservas_vuelo1] FOREIGN KEY([vuelo_regreso_id])
REFERENCES [dbo].[vuelo] ([id])
GO

ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [FK_reservas_vuelo1]
GO


USE [datair]
GO

/****** Object:  Table [dbo].[usuario]    Script Date: 29/09/2018 9:00:48 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[usuario] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [datair]
GO

/****** Object:  Table [dbo].[vuelo]    Script Date: 29/09/2018 9:00:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[vuelo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[avion_id] [int] NULL,
	[fecha_salida] [date] NULL,
	[hora_salida] [time](7) NULL,
	[origen] [varchar](100) NULL,
	[destino] [varchar](100) NULL,
	[aerolinea] [int] NULL,
 CONSTRAINT [PK_vuelo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[vuelo]  WITH CHECK ADD  CONSTRAINT [FK_vuelo_vuelo] FOREIGN KEY([avion_id])
REFERENCES [dbo].[avion] ([id])
GO

ALTER TABLE [dbo].[vuelo] CHECK CONSTRAINT [FK_vuelo_vuelo]
GO


