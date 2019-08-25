## ESTOQUE
### 1 - Micro Service API<br>
  CRUD para Produtos e Categorias <br><br>
  Utilizando o .NET CORE 2.1<br><br>
  ARQUIVO <b>mysql_script.SQL</b> contem o script para a criação do banco de dados.<br>
  os dados de conexão ficam no arquivo <b>appsettings.json</b>:<br>
    "ConnectionStrings": {
    "DefaultConnection": "server=localhost;..."
  },<br>
  Criado banco para rodar no mysql. Com as tabelas <i>estoque</i>, <i>categoria</i>. Optou-se pela criação de <i>stored procedures</i> para retorno e manipulação de dados.<br><br>
  <b>Vai rodar na porta 8000.</b>
#### Back-End
- Micro Serviço
- Injeção de dependência
- DDD (Domain Driven Design) 
- ASP NET Core 2.1
- Swagger

   
### 2 - WEb MVC<br>
Esse projeto segue os mesmos moldes de outro que fiz:<br>
https://github.com/edutomazini/labs<br><br>

Nao consegui terminá-lo para a versao 'Estoque'.<br>
Tive alguns problemas na conversao dos dados da API para o MODEL.<br><br>

* após atualizar os nugets, acatando uma sugestao do github, perdi o layout do <b>Web MVC</b>. Subiro que levem em conta o projeto MVC do repositorio <i>labs</i>.
