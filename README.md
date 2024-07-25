#Passos para execução dos projetos:

1º: Excecutar o clone do repositorio com o comando abaixo:
  git clone https://github.com/SidneiOliveira/b3-avaliacao.git
2º Acessar a pasta "b3-avaliacao"

#Executando o back-end (.Net)

1º Acessar a pasta "CalculoCDBSolution"
2º Abrir o arquivo "CalculoCDBSolution.sln" com Visual Studio
3º Do Lado direito na aba "Solution Explorer", clicar com o botão direito no primeiro item (CalculoCDBSolution)
5º Selecionar a opção "Build Solution"
  * ![image](https://github.com/user-attachments/assets/cdc7954c-967f-4b34-a0b6-635325cf2a46)
6º Do Lado direito na aba "Solution Explorer", clicar com o botão direito no item (CalculoCDBWebApi)
7º Selecionar a opção "Set as Startup Project"
  * ![image](https://github.com/user-attachments/assets/c8cb81df-0abb-424c-ab6c-7d1aa8deaf34)
8º Exceutar pelo comando Ctrl+F5 ou apenas F5
9º Caso o navegador não se abra, acessar a url abaixo:
  https://localhost:7038/swagger/index.html
  * A tela deve se parecer com algo abaixo:
  * ![image](https://github.com/user-attachments/assets/5ecd9238-2d7d-4e55-86e0-6625e32b8e53)

#Executando o front-end (Angular)

1º Dentro da pasta abrir o git-bash ou cli de preferência
2º Garantir que está na branch main
3º Executar o comando abaixo:
  ng serve
  * ![image](https://github.com/user-attachments/assets/0f67b12d-82a4-4dc6-b124-d39dd971d4fc)

4º Caso o navegador não se abra, acessar a url abaixo:
  http://localhost:4200
  * A tela deve se parecer com algo abaixo:
  * ![image](https://github.com/user-attachments/assets/939fe34d-8275-46be-a836-23b241bfe840)

#Executando testes unitarios no back-end (.Net)
1º Do Lado direito na aba "Solution Explorer", clicar com o botão direito no primeiro item (CalculoCDBSolution)
2º Selecionar a opção "Run Tests"
3º No canto inferior esquerdo será apresentada uma aba chamada "Test Explorer", obs: caso não seja exibida:
  No canto superio esquerdo no menu "View", selecione a opção "Test Explorer", uma vez selecionada,
    esta opção ficará disponível no canto inferior esquerdo para análise dos testes executados
    *![image](https://github.com/user-attachments/assets/ea930b69-191a-4bf0-a2ba-783f659ef516)

