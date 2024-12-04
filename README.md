# BrownianMotionAPP

Brownian Motion Simulator
Descri��o
Este projeto � uma aplica��o .NET MAUI que simula o movimento browniano, utilizado em finan�as para modelar o comportamento estoc�stico dos pre�os. A aplica��o gera um gr�fico representando o movimento browniano com base em par�metros fornecidos pelo usu�rio. Ela permite a visualiza��o interativa do gr�fico com funcionalidades de zoom e personaliza��o.
Funcionalidades
�	Gera��o do gr�fico de movimento browniano: A simula��o � realizada com base nos par�metros inseridos pelo usu�rio, como pre�o inicial, volatilidade, m�dia de retorno e tempo (em dias).
�	Zoom interativo: Permite que o usu�rio fa�a zoom no gr�fico, seja utilizando os bot�es de zoom ou gestos de pinch.
�	Interface intuitiva: A aplica��o tem uma interface simples e f�cil de usar, feita com .NET MAUI e padr�o MVVM.
Tecnologias Utilizadas
�	.NET 8
�	.NET MAUI para a interface gr�fica.
�	C# para a implementa��o da l�gica de neg�cios e gera��o do gr�fico.
�	Pinch Gesture para implementar o zoom interativo.
Estrutura do Projeto
�	MainPage.xaml: Interface gr�fica onde o usu�rio interage com a aplica��o.
�	MainViewModel.cs: Cont�m a l�gica de neg�cios, como a gera��o dos dados do gr�fico e controle de zoom.
�	ChartDrawable.cs: Classe respons�vel por desenhar o gr�fico de movimento browniano com base nos dados.
�	BrownianMotionModel.cs: Cont�m o c�digo para gerar o movimento browniano a partir dos par�metros fornecidos.
Como Rodar o Projeto
Pr�-requisitos
1.	Instalar o .NET 8 SDK: Certifique-se de ter o .NET 8 SDK instalado. Voc� pode baix�-lo aqui.
2.	Instalar o Visual Studio com o suporte para .NET MAUI.
3.	Configurar o ambiente para rodar aplicativos .NET MAUI em um emulador ou dispositivo.
Passos para executar
1.	Clone o reposit�rio:
bash
Copiar c�digo
git clone https://github.com/seu-usuario/BrownianMotionSimulator.git
2.	Navegue at� o diret�rio do projeto:
bash
Copiar c�digo
cd BrownianMotionSimulator
3.	Abra o projeto no Visual Studio.
4.	Selecione o emulador ou dispositivo para rodar a aplica��o.
5.	Execute a aplica��o clicando no bot�o "Iniciar" no Visual Studio.
6.	Insira os par�metros de simula��o (pre�o inicial, volatilidade, m�dia de retorno, tempo) e clique em "Gerar Gr�fico". Utilize os bot�es de zoom ou gestos de pinch para interagir com o gr�fico.
Par�metros de Entrada
1.	Pre�o Inicial: O valor inicial do ativo.
2.	Volatilidade: A volatilidade do ativo (expressa como uma porcentagem).
3.	M�dia de Retorno: A m�dia de retorno do ativo (expressa como uma porcentagem).
4.	Tempo (em dias): O n�mero de dias para o qual a simula��o ser� realizada.
Funcionalidade de Zoom
�	Zoom In: Aumenta o zoom do gr�fico.
�	Zoom Out: Diminui o zoom do gr�fico.
�	Pinch Gesture: Permite o zoom utilizando gestos de pinch no gr�fico.
Como Contribuir
1.	Fa�a um fork do reposit�rio.
2.	Crie uma branch para sua feature ou corre��o (git checkout -b feature/MinhaFeature).
3.	Fa�a commit das suas mudan�as (git commit -m 'Adicionando minha feature').
4.	Push para a branch (git push origin feature/MinhaFeature).
5.	Abra um Pull Request no reposit�rio original.
Licen�a
Este projeto � licenciado sob a Licen�a MIT - veja o arquivo LICENSE para mais detalhes.
________________________________________
Exemplos de Uso
1.	Gerar Gr�fico: Ao inserir os par�metros como pre�o inicial, volatilidade, m�dia de retorno e tempo, clique em "Gerar Gr�fico" para visualizar a simula��o.
2.	Zoom: Utilize os bot�es de zoom ou fa�a gestos de pinch para ampliar ou reduzir a visualiza��o do gr�fico.

