<center><h1>DESAFIO 1045 URI ONLINE</h1></center>

<p>Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:</p>

<ul>
<li>se A ≥ B+C, apresente a mensagem: <b>NAO FORMA TRIANGULO</b></li>
<li>se A² = B² + C², apresente a mensagem: <b>TRIANGULO RETANGULO</b></li>
<li>se A² > B² + C², apresente a mensagem: <b>TRIANGULO OBTUSANGULO</b></li>
<li>se A² < B² + C², apresente a mensagem: <b>TRIANGULO ACUTANGULO</b></li>
<li>se os três lados forem iguais, apresente a mensagem: <b>TRIANGULO EQUILATERO</b></li>
<li>se apenas dois dos lados forem iguais, apresente a mensagem: <b>TRIANGULO ISOSCELES</b></li></ul>

<h3>Entrada:</h3>

<p>A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).</p>

<h3>Saída:</h3>

<p>Imprima todas as classificações do triângulo especificado na entrada.</p>

| Exemplo de Entrada |                Exemplo de Saída                |
| ------------------ | :--------------------------------------------: |
| 7.0 5.0 7.0        | TRIANGULO ACUTANGULO<br />TRIANGULO ISOSCELES  |
| 6.0 6.0 10.0       | TRIANGULO OBTUSANGULO<br />TRIANGULO ISOSCELES |
| 6.0 6.0 6.0        | TRIANGULO ACUTANGULO<br />TRIANGULO EQUILATERO |
| 5.0 7.0 2.0        |              NAO FORMA TRIANGULO               |
| 6.0 8.0 10.0       |              TRIANGULO RETANGULO               |

