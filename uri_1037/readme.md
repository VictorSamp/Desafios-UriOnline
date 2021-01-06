<center><h1>DESAFIO 1037 URI ONLINE</h1></center>

<p>Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.</br>
O símbolo ( representa "maior que". Por exemplo:</br>
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.</br>
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000</p>

<h3>Entrada:</h3>

<p>O arquivo de entrada contém um número com ponto flutuante qualquer.</p>

<h3>Saída:</h3>

<p>A saída deve ser uma mensagem conforme exemplo abaixo.</p>

| Exemplo de Entrada |  Exemplo de Saída  |
| ------------------ | :----------------: |
| 25.01              | Intervalo (25,50]  |
| 25.00              |  Intervalo [0,25]  |
| 100.00             | Intervalo (75,100] |
| -25.02             | Fora de intervalo  |

