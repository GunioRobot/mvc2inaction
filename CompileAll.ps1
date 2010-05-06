foreach($file in get-childitem -filter *.sln -recurse)
{
    echo Compiling $file.FullName
    \Windows\Microsoft.NET\Framework\v3.5\msbuild.exe /t:build /v:q /nologo $file.FullName
}