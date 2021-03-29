
@REM 削除。
RMDIR /S /Q "Assets\UPM\Samples~"

XCOPY "Assets\Samples\JsonItem" "Assets\UPM\Samples~\" /E /Y

@PAUSE