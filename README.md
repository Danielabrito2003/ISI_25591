# [ISI] Trabalho Prático 1

## Autor
### Nome: 
Daniela Brito
### Número de Aluno: 
25591
### Curso: 
Licenciatura em Engenharia de Sistemas Informáticos, 3º Ano
### U.C.: 
Integração de Sistemas de Informação
### Docente: 
Professor Óscar Ribeiro
### Descrição do Projeto:
Este projeto foi desenvolvido no âmbito da disciplina de Integração de Sistemas de Informação, focando-se na criação de um processo ETL (Extração, Transformação e Carga) com recurso ao Pentaho Kettle. O objetivo é migrar dados de um ficheiro CSV, transformá-los aplicando operações de normalização e exportá-los em dois formatos distintos: JSON e Excel.

## Objetivos do Trabalho:
Limpeza de dados: Correção de preços, validação de e-mails e remoção de entradas duplicadas.
Normalização de preços para o formato correto (ex.: 59,50€).
Conversão para JSON (para APIs e sistemas web) e Excel (para relatórios e análises empresariais).

## Estrutura de Pastas e Ficheiros
```
tp01-25591/
├── README.md
├── doc/
│   └── relatorio_25591.pdf
├── dataint/
│   ├── TP01_25591.ktr
│   └── Enviar_Tabela_Email.kjb
├── data/
│   ├── input/
│   │   └── Base_dados.csv
│   └── output/
│       ├── Base_dados.json
│       └── Base_dados.xlsx
└── src/
    └── N/A
```


## Instruções para Execução

### Ferramentas Necessárias:
 - Pentaho Data Integration (Kettle): Ferramenta ETL utilizada para a criação e execução das transformações e jobs.
 - Python 3: Para executar scripts adicionais de apoio, se necessário.

### Passos para Executar o ETL:
 - Abrir o Pentaho Data Integration (Kettle).
 - Abrir Job ETL. Abrir a pasta dataint/ e abrir o ficheiro TP01_25591.ktr.
 - Executar o job para processar os ficheiros de entrada e gerar os dados de saída.
 - Verificar o Resultado. Os ficheiros de saída serão guardados na pasta dataoutput/.
