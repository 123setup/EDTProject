echo off & cls

echo 正在尝试编译...
devenv.com core/EncryptionTools.sln /build Release /out build.log
echo 编译成功!按任意键退出!
pause > nul