# Arquitetura Orientada à Serviços com .NET Aspire

O projeto possui 3 aplicações API REST convencional e uma API Gateway. O próprio Aspire toma conta de colocar de executar as APIs no ambiente de desenvolvimento. <br/>
Com isso, o Gateway está configurado para acessar as rotas das outras 3 APIs diretamento por ele. Na dashboard do Aspire podemos ver todas as aplicações rodando com suas devidas portas e documentação, entretando todas as requisições devem ser feitas ao gateway<br/>

Exemplo:
A rota localhost:5001/academico/aluno da Api Academico, deve ser solicitada com a URL localhost:5063/api/academico/aluno. Para ver as regras de roteamento, consulte o arquivo ocelot.json da API Gateway
