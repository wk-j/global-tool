## Create .NET Global Tool

- .NET Core 2.1.0-preview1-26216-03

```
dotnet new global-tool --output src/AwesomeTool

cake -target=Pack
dotnet install tool -g AwesomeTool --source ./publish
awesome-tool
```

## Add tool path (Fish)

```
echo 'set -gx PATH ~/.dotnet/tools $PATH' >>  ~/.config/fish/config.fish
```
