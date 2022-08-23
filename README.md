# Api Aluno
API-(ASP.Net Core) que vai conter as funções do CRUD e essa mesma api vai ser consumida por uma aplicação Reactjs: https://github.com/thiagoadssilva/UdemyReactjApiAluno
<hr>


## Observações:
* Depois de baixar o projeto do git você vai precisar rodar os camandos das migrations com os comandos a seguir:
    - No arquivo coloque as configurações do seu localHost -> https://github.com/thiagoadssilva/UdemyApiAlunoReactj/blob/main/AlunosAPI/AlunosAPI/appsettings.json
    - dotnet ef migrations add 'nomedamigração'
    - dotnet ef database update