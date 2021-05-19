#language: pt
Funcionalidade: Login
	Como cliente da loja
	Quero realizar login no site

Contexto: 
	Dado que eu acesse o site e vá até a página de login

@AT02
Cenario: Realizar login com sucesso
	Dado que eu esteja na página de login
	Quando insiro usuário e senha válidos
	Entao o login é realizado com sucesso