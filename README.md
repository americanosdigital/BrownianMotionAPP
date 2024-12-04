Brownian Motion Simulator

Descrição
Este projeto é uma aplicação .NET MAUI que simula o movimento browniano, utilizado em finanças para modelar o comportamento estocástico dos preços. A aplicação gera um gráfico representando o movimento browniano com base em parâmetros fornecidos pelo usuário. Ela permite a visualização interativa do gráfico com funcionalidades de zoom e personalização.

Funcionalidades
Geração do gráfico de movimento browniano: A simulação é realizada com base nos parâmetros inseridos pelo usuário, como preço inicial, volatilidade, média de retorno e tempo (em dias).
Zoom interativo: Permite que o usuário faça zoom no gráfico, seja utilizando os botões de zoom ou gestos de pinch.
Interface intuitiva: A aplicação tem uma interface simples e fácil de usar, feita com .NET MAUI e padrão MVVM.
Tecnologias Utilizadas
.NET 8
.NET MAUI para a interface gráfica.
C# para a implementação da lógica de negócios e geração do gráfico.
Pinch Gesture para implementar o zoom interativo.
Estrutura do Projeto
MainPage.xaml: Interface gráfica onde o usuário interage com a aplicação.
MainViewModel.cs: Contém a lógica de negócios, como a geração dos dados do gráfico e controle de zoom.
ChartDrawable.cs: Classe responsável por desenhar o gráfico de movimento browniano com base nos dados.
BrownianMotionModel.cs: Contém o código para gerar o movimento browniano a partir dos parâmetros fornecidos.
Como Rodar o Projeto
Pré-requisitos
Instalar o .NET 8 SDK: Certifique-se de ter o .NET 8 SDK instalado. Você pode baixá-lo aqui.
Instalar o Visual Studio com o suporte para .NET MAUI.
Configurar o ambiente para rodar aplicativos .NET MAUI em um emulador ou dispositivo.
Passos para executar
Clone o repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/BrownianMotionSimulator.git
Navegue até o diretório do projeto:

bash
Copiar código
cd BrownianMotionSimulator
Abra o projeto no Visual Studio.

Selecione o emulador ou dispositivo para rodar a aplicação.

Execute a aplicação clicando no botão "Iniciar" no Visual Studio.

Insira os parâmetros de simulação (preço inicial, volatilidade, média de retorno, tempo) e clique em "Gerar Gráfico". Utilize os botões de zoom ou gestos de pinch para interagir com o gráfico.

Parâmetros de Entrada
Preço Inicial: O valor inicial do ativo.
Volatilidade: A volatilidade do ativo (expressa como uma porcentagem).
Média de Retorno: A média de retorno do ativo (expressa como uma porcentagem).
Tempo (em dias): O número de dias para o qual a simulação será realizada.
Funcionalidade de Zoom
Zoom In: Aumenta o zoom do gráfico.
Zoom Out: Diminui o zoom do gráfico.
Pinch Gesture: Permite o zoom utilizando gestos de pinch no gráfico.
Como Contribuir
Faça um fork do repositório.
Crie uma branch para sua feature ou correção (git checkout -b feature/MinhaFeature).
Faça commit das suas mudanças (git commit -m 'Adicionando minha feature').
Push para a branch (git push origin feature/MinhaFeature).
Abra um Pull Request no repositório original.
Licença
Este projeto é licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.

Exemplos de Uso
Gerar Gráfico: Ao inserir os parâmetros como preço inicial, volatilidade, média de retorno e tempo, clique em "Gerar Gráfico" para visualizar a simulação.

Zoom: Utilize os botões de zoom ou faça gestos de pinch para ampliar ou reduzir a visualização do gráfico.
