USE [VentasLeon]
GO
/****** Object:  StoredProcedure [dbo].[usp_ListarFacturasVendedor]    Script Date: 17/10/2014 02:34:42 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_ListarFacturasVendedorFechas]
@codven char(3),
@fecini smalldatetime,
@fecfin smalldatetime
as
Select num_fac,fec_fac,fec_can,total,estado
from vw_VistaFacturas
where cod_ven=@codven and
      fec_fac between @fecini and @fecfin 
	  go

Create Procedure [dbo].[usp_ListarFacturasClienteFechas]
@codcli char(4),
@fecini smalldatetime,
@fecfin smalldatetime
as
Select num_fac,fec_fac,fec_can,total,estado
from vw_VistaFacturas
where cod_cli=@codcli and
      fec_fac between @fecini and @fecfin 
	  go