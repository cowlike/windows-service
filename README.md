# Overview

```bash
dotnet publish -r win7-x86 \
    -c Release -o /c/apps/testapps/workertest \
    -p:PublishSingleFile=True \
    -p:PublishTrimmed=True \
    -p:UseAppHost=True
```
