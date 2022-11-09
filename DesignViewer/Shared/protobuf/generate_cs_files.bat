if not exist "%~dp0..\Design\Generated" mkdir %~dp0..\Design\Generated

for /R %~dp0\design %%G in (*.proto) do protoc -I=%~dp0\design --csharp_out=%~dp0..\Design\Generated --csharp_opt=file_extension=.g.cs,base_namespace=Aurigma.Design %%~fG

exit 0