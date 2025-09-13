@echo off
:: Solicitar el nombre del proyecto al usuario
set /p project_name="Introduce el nombre de tu proyecto C#: "

:: Verificar si el nombre está vacío
if "%project_name%"=="" (
    echo No se ha proporcionado un nombre de proyecto. Saliendo...
    exit /b 1
)

:: Crear un directorio con el nombre del proyecto
mkdir "%project_name%"

:: Cambiar al directorio del proyecto
cd "%project_name%"

:: Crear un proyecto de consola en C# con .NET Core
dotnet new console -n "%project_name%"

echo Proyecto C# "%project_name%" creado exitosamente en el directorio %cd%
pause
