%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe HippoKinectOverLoader.exe
Net Start HippoKinectOverloader
sc config HippoKinectOverloader start= auto
pause