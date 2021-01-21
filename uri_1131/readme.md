<center><h1>DESAFIO 1131 URI ONLINE</h1></center>

A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

\- Quantos GRENAIS fizeram parte da estatística.
\- O número de vitórias do Inter.
\- O número de vitórias do Grêmio.
\- O número de Empates.
\- Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

<h3>Entrada:</h3>

O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. Em seguida háverá um inteiro (1 ou 2), correspondente à repetição do programa.

<h3>Saída:</h3>

Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". Quando o algoritmo for encerrado devem ser mostradas as estatísticas conforme a descrição apresentada acima. Obs: a palavra "Gremio" deve ser impressa sem acento, conforme o exemplo abaixo.



| Exemplo de Entrada                          | Exemplo de Saída                                             |
| ------------------------------------------- | :----------------------------------------------------------- |
| 3 2<br />1<br />2 3 <br />1<br />3 1<br />2 | Novo grenal (1-sim 2-nao)<br />Novo grenal (1-sim 2-nao)<br />Novo grenal (1-sim 2-nao)<br />3 grenais<br />Inter: 2<br />Gremio: 1<br />Empates: 0<br />Inter venceu mais |

