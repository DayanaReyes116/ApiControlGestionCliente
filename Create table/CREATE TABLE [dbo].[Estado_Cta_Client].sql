SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estado_Cta_Client](
	[Id] [bigint] NOT NULL,
	[IdCuenta_Client] [bigint] NULL,
	[Ingreso] [decimal] (14,2),
	[Egreso] [decimal] (14,2),
	[Saldo] [decimal] (14,2),
	[Created] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Estado_Cta_Client]  WITH CHECK ADD  CONSTRAINT [Fk_Edo_CtaCliente] FOREIGN KEY([IdCuenta_Client])
REFERENCES [dbo].[Cuenta_Client] ([Id])
GO

ALTER TABLE [dbo].[Estado_Cta_Client] CHECK CONSTRAINT [Fk_Edo_CtaCliente] 

