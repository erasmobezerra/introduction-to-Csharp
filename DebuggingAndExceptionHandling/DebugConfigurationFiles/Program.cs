/*
==== Criar um arquivo de configuração de depuração ====

O Visual Studio Code usa o arquivo launch.json para configurar o depurador. Se você estiver criando um aplicativo de console C# simples, 
provavelmente, o Visual Studio Code vai gerar um arquivo launch.json com todas as informações necessárias para depurar o código com sucesso. 
No entanto, há casos em que você precisa modificar uma configuração de inicialização, ou seja, é importante entender os atributos de uma configuração de inicialização.


==== Atributos de uma configuração de inicialização ====
O arquivo launch.json inclui uma ou mais configurações de inicialização na lista configurations. As configurações de inicialização usam atributos para dar suporte a diferentes cenários de depuração. Os seguintes atributos são obrigatórios para cada configuração de inicialização:

name: o nome amigável do leitor atribuído à configuração de inicialização.

type: o tipo de depurador a ser usado para a configuração de inicialização. codeclr especifica o tipo de depurador para aplicativos .NET Core e 
      .NET 5 e posterior (incluindo aplicativos C#).

request: o tipo de solicitação da configuração de inicialização. Atualmente, só há suporte para os valores launch e attach.

preLaunchTask: especifica uma tarefa a ser executada antes da depuração do programa. A tarefa em si pode ser encontrada no arquivo tasks.json, 
               que está na pasta .vscode com o arquivo launch.json. A especificação de uma tarefa de pré-inicialização de build executa um comando 
               dotnet build antes da inicialização do aplicativo.

program:  é definido como o caminho da DLL do aplicativo ou do executável de host do .NET Core a ser iniciado.      

cwd: especifica o diretório de trabalho do processo de destino.

args: especifica os argumentos que são transmitidos para o programa na inicialização. Não há argumentos por padrão.

console: especifica o tipo de console usado quando o aplicativo é iniciado. As opções são internalConsole, integratedTerminal e externalTerminal. 

stopAtEntry: Caso você precise parar no ponto de entrada do destino, opcionalmente, defina stopAtEntry como true.



===== Para criar um arquivo inicial:launch.json ======
Há muitos cenários em que talvez seja necessário personalizar o arquivo de configuração de inicialização. 
Este módulo tem como foco dois cenários simples quando a atualização do arquivo de configuração de inicialização é necessária:

-> Seu aplicativo de console C# lê a entrada do console.
-> O workspace do projeto inclui mais de um aplicativo.

Arquivo launch.json: 

``` JSON

"version": "0.2.0",
"configurations": [
    {
        "name": "Launch Project123",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject123",
        "program": "${workspaceFolder}/Project123/bin/Debug/net7.0/Project123.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project123",
        "console": "internalConsole",
        "stopAtEntry": false
    },
    {
        "name": "Launch Project456",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "buildProject456",
        "program": "${workspaceFolder}/Project456/bin/Debug/net7.0/Project456.dll",
        "args": [],
        "cwd": "${workspaceFolder}/Project456",
        "console": "internalConsole",
        "stopAtEntry": false
    }
]

``` 

O atributo preLaunchTask é usado para especificar o nome da tarefa executada antes da inicialização do depurador.
Ou seja, especifica que seja realizado o build do projeto antes da depuração em si. 
Isso garante que a depuração seja realizada sempre com o projeto atualizado. 

O arquivo tasks.json contém as tarefas nomeadas e as informações necessárias para concluir a tarefa.

``` JSON

"version": "2.0.0",
"tasks": [
    {
        "label": "buildProject123",
        "command": "dotnet",
        "type": "process",
        "args": [
            "build",
            "${workspaceFolder}/Project123/Project123.csproj",
            "/property:GenerateFullPaths=true",
            "/consoleloggerparameters:NoSummary"
        ],
        "problemMatcher": "$msCompile"
    },
    {
        "label": "buildProject456",
        "command": "dotnet",
        "type": "process",
        "args": [
            "build",
            "${workspaceFolder}/Project456/Project456.csproj",
            "/property:GenerateFullPaths=true",
            "/consoleloggerparameters:NoSummary"
        ],
        "problemMatcher": "$msCompile"
    }
]

```

Recapitulação
Estes são dois pontos importantes desta unidade que você deve se lembrar:

As configurações de inicialização são usadas para especificar atributos como name, type, request, preLaunchTask, program e console.
Os desenvolvedores podem editar uma configuração de inicialização para acomodar os requisitos do projeto.

*/