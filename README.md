Ola, seja bem vindo a minha Api de Controle de Boletos e bancos.
O banco de dados ja esta em um serviço Postgres rodando no RDS, ja esta pronto para uso. Ou então se preferir pode ser criado um novo banco atraves das migrations.

Para seu funcionamento primeiro precisamos rodar a Api de Autentição, feita usando o Framework Identity.
![image](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/fb3bfb87-8b47-4bb5-8f49-d85ad8cc2e2b)


Logo em seguida precisamos primerio gerar um token, para isso basta criar um novo cadastro com email, cpf, nome e senha.

![image](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/c55a2cfb-d8c6-4451-a758-59dc11ebe890)

Após isso basta autenticar seu usuario para geração do token de acesso:

![image](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/8cb31a08-6ac5-4c37-b31a-52747d28af38)


Logo em Seguida é a vez de rodarmos nossa Api de Cadastro e Controle de Boletos.
![image](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/d0b9ffec-0bdd-403f-80e2-ed6442d1b2b7)

Logo em seguida basta autorizarmos os serviços de nossa aplicação, isso por ser feito ao clicar em Authorize e logo em seguida, digitar a palavra "bearer" seguida do token gerado pela Api de identificação, como no exemplo a seguir:

![image](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/a0ea2399-5865-4397-831c-7a309ff73dd0)

Após isso a Api estava disponivel para uso, sinta-se a vontade para explora-la.
Obs: Criei os endpoints solicitados no projeto, estarei adicionando novas funcionalidades ao CRUD, como atualização e Delete, qualquer duvida meu email se encontra a disposição, nos vemos por ai, muito obrigado.

Atenciosamente

![ANDERSON BATISTA DA SILVA](https://github.com/gregprog2020/ControleBoletosBancos.Api/assets/61755648/814ac725-8700-42e7-abd9-1f65d3ee78f6)



