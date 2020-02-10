﻿Module MissingEnumerations
    Public Enum ccdsoftInventoryIndex As Integer
        cdInventoryX
        cdInventoryY
        cdInventoryMagnitude
        cdInventoryClass
        cdInventoryFWHM
        cdInventoryMajorAxis
        cdInventoryMinorAxis
        cdInventoryTheta
        cdInventoryEllipticity
    End Enum

    Enum ccdsoftWCSIndex As Integer
        cdWCSRA
        cdWCSDec
        cdWCSX
        cdWCSY
        cdWCSPositionError
        cdWCSResidual
        cdWCSCatalogID
        cdActive
    End Enum

    Enum ccdsoftAutoContrastMethod As Integer
        cdAutoContrastUseAppSetting = -1
        cdAutoContrastSBIG
        cdAutoContrastBjorn
        cdAutoContrastDSS100X
    End Enum

    Enum ccdsoftBjornBackground As Integer
        cdBgNone
        cdBgWeak
        cdBgMedium
        cdBgStrong
        cdBgVeryStrong
    End Enum

    Enum ccdsoftBjornHighlight As Integer
        cdHLNone
        cdHLWeak
        cdHLMedium
        cdHLStrong
        cdHLVeryStrong
        cdHLAdaptive
        cdHLPlanetary
    End Enum

    Enum ccdsoftCoordinates As Integer
        cdRA
        cdDec
    End Enum

    Enum ccdsoftSaveAs As Integer
        cdGIF
        cdBMP
        cdJPG
        cd48BitTIF
    End Enum

End Module
