# PrepareSDK.ps1

$sdkDirPath = Join-Path $PSScriptRoot "SDK"
$zipNameWoExt = "ILSpy_binaries_4.0.1.4530"
$zipName = "$zipNameWoExt.zip"
$zipPath = Join-Path $sdkDirPath $zipName
$zipUri = "https://github.com/icsharpcode/ILSpy/releases/download/v4.0.1/$zipName"
$destDirPath = Join-Path $sdkDirPath $zipNameWoExt
$testPath = Join-Path $destDirPath "ILSpy.exe"

if (!(Test-Path -LiteralPath $testPath)) {
    if (!(Test-Path -LiteralPath $zipPath)) {
        if (!(Test-Path -LiteralPath $destDirPath)) {
            New-Item -ItemType Directory $destDirPath
        }
        [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12
        Invoke-WebRequest -Uri $zipUri -OutFile $zipPath
    }
    Expand-Archive -Path $zipPath -DestinationPath $destDirPath
}
