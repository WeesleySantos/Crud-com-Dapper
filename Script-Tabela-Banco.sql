USE [CadastroUsuario]
GO
/****** Object:  Table [dbo].[Cadastro]    Script Date: 16/10/2022 15:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadastro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[SobreNome] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Endereco] [varchar](100) NULL,
 CONSTRAINT [PK_Cadastro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
