
# [ISI] Trabalhos Práticos

## Autor
**Nome:** Daniela Brito  
**Número de Aluno:** 25591  
**Curso:** Licenciatura em Engenharia de Sistemas Informáticos, 3º Ano  
**U.C.:** Integração de Sistemas de Informação  
**Docente:** Professor Óscar Ribeiro  
**Ano:** 2024/2025  

---

## Descrição deste Repositório
Este repositório contém os trabalhos práticos desenvolvidos no âmbito da unidade curricular de Integração de Sistemas de Informação. O foco principal é a exploração de processos ETL (Extração, Transformação e Carga) e a criação de APIs para interoperabilidade entre sistemas, utilizando serviços web. Cada trabalho apresenta uma abordagem prática para aplicar conceitos teóricos aprendidos na aula, usando ferramentas como o Pentaho Kettle, Node-RED, e linguagens modernas.

## Estrutura de Pastas e Ficheiros
```
isi-trabalhos/
├── TP1/                    # Trabalho Prático 1 - Processos ETL
│   ├── README.md           # Detalhes do projeto
│   ├── doc/                # Relatório e documentação
│   │   └── relatorio_TP1.pdf
│   ├── data/               # Dados utilizados no processo ETL
│   │   ├── input/          # Dados de entrada (ex.: CSV)
│   │   └── output/         # Dados transformados (ex.: JSON, Excel)
│   ├── dataint/            # Ficheiros Pentaho (jobs e transformações)
│   └── src/                # Scripts de apoio, se aplicável
│
├── TP2/                    # Trabalho Prático 2 - Serviços Web e APIs
│   ├── README.md           # Detalhes do projeto
│   ├── doc/                # Relatório e documentação
│   │   └── relatorio_TP2.pdf
│   ├── api/                # Código da API desenvolvida
│   ├── tests/              # Scripts de testes da API
│   └── client/             # Aplicação cliente para testar a API
│
└── README.md               # Documento principal do repositório
```

## Trabalhos Incluídos

### **Trabalho Prático 1 - Processos ETL**
- **Descrição:** Desenvolvimento de processos ETL usando Pentaho Kettle para extração, transformação e carregamento de dados de ficheiros CSV, com saída em formatos JSON e Excel.
- **Objetivos:**
  - Limpeza e validação de dados.
  - Normalização de valores.
  - Exportação para formatos variados.
- **Foco nas Ferramentas:** Pentaho Kettle, Node-RED, Expressões Regulares.

### **Trabalho Prático 2 - Serviços Web e APIs**
- **Descrição:** Criação de serviços RESTful e, opcionalmente, SOAP para suportar operações CRUD e demonstrar a integração entre sistemas através de APIs.
- **Objetivos:**
  - Desenvolver serviços para interoperabilidade.
  - Implementar segurança (tokens OAuth).
  - Documentar a API usando Swagger/OpenAPI.
- **Foco nas Ferramentas:** Node.js, Postman, ou plataformas PaaS (Azure, AppHarbor).

---

## Instruções para Uso
1. **Navegar nas Pastas:** Cada trabalho está isolado numa pasta com o seu respetivo `README.md`, que contém detalhes sobre o projeto e instruções específicas.
2. **Ferramentas Necessárias:** Certifica-te de que tens as ferramentas necessárias instaladas, como Pentaho Kettle, Node.js, ou outras especificadas nos projetos.
3. **Executar os Trabalhos:** Segue as instruções de cada trabalho individual para a execução dos ficheiros ou testes.

---