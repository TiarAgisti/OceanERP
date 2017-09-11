USE [OCEANERP]
GO

/****** Object:  View [dbo].[v_BonOrderDetail]    Script Date: 08-Sep-17 20:16:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [dbo].[v_BonOrderDetail]
AS

select bonDet.*
		, fb.FabricName + ' - ' +sty.StyleName as StyleName
		, CASE WHEN fb.Width IS NULL THEN '' ELSE fb.Width END Width
		, CASE WHEN fb.Weight IS NULL THEN '' ELSE fb.Weight END Weight
FROM BonOrderDetail AS bonDet
LEFT JOIN BonOrderHeader AS bonH ON bonH.BonOrderID = bonDet.BonOrderID
LEFT JOIN Fabric as fb ON fb.FabricID = bonDet.FabricID
LEFT JOIN Colors as co ON co.ColorID = bonDet.ColorID 
LEFT JOIN Style as sty ON sty.StyleID = bonDet.StyleID


GO


