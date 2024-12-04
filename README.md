Brownian Motion Simulator
Descrição
Este projeto é uma aplicação .NET MAUI que simula o movimento browniano, utilizado em finanças para modelar o comportamento estocástico dos preços. A aplicação gera um gráfico representando o movimento browniano com base em parâmetros fornecidos pelo usuário. Ela permite a visualização interativa do gráfico com funcionalidades de zoom e personalização.
Funcionalidades
•	Geração do gráfico de movimento browniano: A simulação é realizada com base nos parâmetros inseridos pelo usuário, como preço inicial, volatilidade, média de retorno e tempo (em dias).
•	Zoom interativo: Permite que o usuário faça zoom no gráfico, seja utilizando os botões de zoom ou gestos de pinch.
•	Interface intuitiva: A aplicação tem uma interface simples e fácil de usar, feita com .NET MAUI e padrão MVVM.
Tecnologias Utilizadas
•	.NET 8
•	.NET MAUI para a interface gráfica.
•	C# para a implementação da lógica de negócios e geração do gráfico.
•	Pinch Gesture para implementar o zoom interativo.
Estrutura do Projeto
•	MainPage.xaml: Interface gráfica onde o usuário interage com a aplicação.
•	MainViewModel.cs: Contém a lógica de negócios, como a geração dos dados do gráfico e controle de zoom.
•	ChartDrawable.cs: Classe responsável por desenhar o gráfico de movimento browniano com base nos dados.
•	BrownianMotionModel.cs: Contém o código para gerar o movimento browniano a partir dos parâmetros fornecidos.
Como Rodar o Projeto
Pré-requisitos
1.	Instalar o .NET 8 SDK: Certifique-se de ter o .NET 8 SDK instalado. Você pode baixá-lo aqui.
2.	Instalar o Visual Studio com o suporte para .NET MAUI.
3.	Configurar o ambiente para rodar aplicativos .NET MAUI em um emulador ou dispositivo.
Passos para executar
1.	Clone o repositório:
bash
Copiar código
git clone https://github.com/seu-usuario/BrownianMotionSimulator.git
2.	Navegue até o diretório do projeto:
bash
Copiar código
cd BrownianMotionSimulator
3.	Abra o projeto no Visual Studio.
4.	Selecione o emulador ou dispositivo para rodar a aplicação.
5.	Execute a aplicação clicando no botão "Iniciar" no Visual Studio.
6.	Insira os parâmetros de simulação (preço inicial, volatilidade, média de retorno, tempo) e clique em "Gerar Gráfico". Utilize os botões de zoom ou gestos de pinch para interagir com o gráfico.
Parâmetros de Entrada
1.	Preço Inicial: O valor inicial do ativo.
2.	Volatilidade: A volatilidade do ativo (expressa como uma porcentagem).
3.	Média de Retorno: A média de retorno do ativo (expressa como uma porcentagem).
4.	Tempo (em dias): O número de dias para o qual a simulação será realizada.
Funcionalidade de Zoom
•	Zoom In: Aumenta o zoom do gráfico.
•	Zoom Out: Diminui o zoom do gráfico.
•	Pinch Gesture: Permite o zoom utilizando gestos de pinch no gráfico.
Como Contribuir
1.	Faça um fork do repositório.
2.	Crie uma branch para sua feature ou correção (git checkout -b feature/MinhaFeature).
3.	Faça commit das suas mudanças (git commit -m 'Adicionando minha feature').
4.	Push para a branch (git push origin feature/MinhaFeature).
5.	Abra um Pull Request no repositório original.
Licença
Este projeto é licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.
________________________________________
Exemplos de Uso
1.	Gerar Gráfico: Ao inserir os parâmetros como preço inicial, volatilidade, média de retorno e tempo, clique em "Gerar Gráfico" para visualizar a simulação.
2.	Zoom: Utilize os botões de zoom ou faça gestos de pinch para ampliar ou reduzir a visualização do gráfico.

