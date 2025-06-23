
# README — Trabalho Prático – Fundamentos de Projeto e Análise de Algoritmos

## Tema  
**Descobrindo padrões — a jornada para sincronizar dados complexos**

## Integrantes  
- Daniel Oliveira  
- Danilo Oliveira  
- Humberto Roosvelt  
- Luiz Almeida  
- Matheus Antão  
- Rafael Bernardoni  
- Saul Netto  
- Vitor Hugo  

## Data  
Junho de 2025

---

## 1. Como a Programação Dinâmica foi aplicada na solução?  

A Programação Dinâmica foi utilizada na construção de uma matriz (`dp`) que armazena os tamanhos das maiores subsequências comuns (LCS) para todos os prefixos das duas sequências fornecidas (Helena e Marcus).  

O preenchimento da matriz segue a seguinte lógica:  
- Se os caracteres atuais de ambas as sequências são iguais, soma-se 1 ao valor da diagonal anterior (`dp[i-1, j-1]`).  
- Caso contrário, seleciona-se o maior valor entre o elemento acima (`dp[i-1, j]`) e o elemento à esquerda (`dp[i, j-1]`).  

Esse processo permite calcular eficientemente o tamanho da LCS entre duas sequências, reduzindo significativamente o custo computacional em relação a uma abordagem de força bruta.

---

## 2. Por que o uso de Backtracking é necessário neste problema?  

A Programação Dinâmica sozinha retorna apenas o tamanho da maior subsequência comum, mas não revela quais são essas subsequências.  

O Backtracking é fundamental para percorrer a matriz `dp` construída e reconstruir todas as subsequências possíveis que possuem esse tamanho máximo (LCS).  

Isso é feito retrocedendo pela matriz, seguindo os caminhos válidos, tanto quando há uma coincidência de caracteres (diagonal), quanto quando há empates entre valores (para cima ou para a esquerda), garantindo que todas as possíveis subsequências sejam encontradas.  

Sem backtracking, não seria possível listar todas as subsequências comuns mais longas, que é exatamente o que o problema exige.

---

## 3. Houve desafios na implementação? Quais? Como foram superados?  

Sim, alguns desafios foram enfrentados, entre eles:  
- Entender a diferença entre calcular o tamanho da LCS e gerar as subsequências completas. No início, houve confusão sobre se a Programação Dinâmica sozinha resolveria o problema por completo.  
- Implementar o backtracking corretamente. Foi necessário compreender que, quando há empates na matriz `dp`, o algoritmo deve explorar ambos os caminhos (cima e esquerda), garantindo que nenhuma subsequência válida fique de fora.  
- Validação rigorosa das entradas. Foram adicionadas expressões regulares e controles para garantir que as entradas seguissem exatamente o que o problema solicitava (letras minúsculas, até 80 caracteres).  
- Melhorias na interface gráfica (WPF). Trabalhamos para deixar o sistema intuitivo, organizado e agradável, melhorando tanto a disposição das informações quanto a legibilidade dos resultados no PDF e nas abas do programa.  

Esses desafios foram superados através de testes constantes, leitura da documentação, revisão em grupo e validação com os exemplos fornecidos no roteiro.

---

## 4. Qual é a complexidade da solução proposta?  

### Versão utilizando apenas Programação Dinâmica:  
- Construção da matriz `dp`:  
Tempo = O(m × n), onde m e n são os tamanhos das duas sequências.  
Espaço = O(m × n) para armazenar a matriz `dp`.  

### Versão utilizando Programação Dinâmica + Backtracking:  
- Construção da matriz `dp`:  
Tempo = O(m × n)  
Espaço = O(m × n)  

- Backtracking:  
No pior caso, cada movimento na matriz pode gerar dois caminhos (quando os valores acima e à esquerda são iguais), formando uma árvore binária.  

A complexidade de tempo do backtracking, no pior caso, é aproximadamente:  
O(2^L), onde L é o comprimento da LCS.  

Portanto, a complexidade total é:  
O(m × n) + O(2^L), no pior cenário, onde L é o comprimento da LCS.

---

## 5. O que o grupo aprendeu ao resolver esse problema?  

- Entendemos de forma clara e prática como aplicar Programação Dinâmica para resolver problemas de subsequências.  
- Aprendemos que, embora a Programação Dinâmica resolva o problema de tamanho, ela sozinha não resolve o problema de reconstrução das soluções, sendo o Backtracking uma ferramenta indispensável nesses casos.  
- Consolidamos conhecimentos de estruturação de matrizes, recursão, tratamento de casos com empates e múltiplos caminhos, fundamentais para problemas clássicos de otimização.  
- Além do algoritmo, adquirimos experiência em desenvolvimento de interfaces gráficas (WPF), exportação de dados para PDF, organização de código limpo, documentado e apresentável.  
- Também desenvolvemos habilidades de trabalho em equipe, divisão de tarefas e validação coletiva dos resultados.

---

## Arquivos entregues  
- codigo_dinamica/ — Solução utilizando somente Programação Dinâmica (tamanho da LCS).  
- codigo_dinamica_backtracking/ — Solução utilizando Programação Dinâmica + Backtracking (gera todas as subsequências).  
- README.md — Este documento.  
- Apresentacao.pptx — Slides da apresentação.

---

## Conclusão  

O trabalho proporcionou uma oportunidade real de entender como problemas complexos podem ser solucionados combinando diferentes paradigmas de algoritmos, além de fortalecer nossa capacidade de trabalhar colaborativamente.
