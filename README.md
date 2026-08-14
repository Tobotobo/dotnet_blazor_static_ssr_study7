# dotnet_blazor_static_ssr_study7

## 実験中


https://www.nuget.org/packages/Microsoft.FluentUI.AspNetCore.Templates/5.0.0-rc.5-26219.1

```sh
dotnet new install Microsoft.FluentUI.AspNetCore.Templates@5.0.0-rc.5-26219.1
```


```sh
dotnet new fluentblazorwasm --empty --exclude-launch-settings --no-https -n DotnetStudy.Client
dotnet remove DotnetStudy.Client package Microsoft.AspNetCore.Components.WebAssembly.DevServer

dotnet new fluentblazor --interactivity None --no-https -n DotnetStudy
dotnet add DotnetStudy package Microsoft.AspNetCore.Components.WebAssembly.Server
dotnet add DotnetStudy reference DotnetStudy.Client
```

```sh
dotnet run --project DotnetStudy
dotnet watch --project DotnetStudy
```