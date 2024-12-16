# Trabalho Prático 2 (Gestão de Receitas e Exercícios)

## Autor
**Nome:** Daniela Brito  
**N.º:** 25591  
**Curso:** Licenciatura em Engenharia de Sistemas Informáticos, 3º Ano  
**U.C.:** Integração de Sistemas de Informação  
**Docente:** Professor Óscar Ribeiro  
**Ano:** 2024/2025  

---

## Introdução
Este projeto foi desenvolvido no âmbito da Unidade Curricular de **Integração de Sistemas de Informação** e tem como objetivo implementar uma solução que integre conceitos de **arquitetura de sistemas**, **desenvolvimento de APIs** e **gestão de dados**. A aplicação é composta por dois módulos principais:

1. **Gestão de Receitas**: Permite gerir receitas através de operações CRUD (Create, Read, Update, Delete), como adicionar, listar, atualizar e eliminar receitas.
2. **Gestão de Exercícios**: Tal como o módulo de receitas, permite a gestão completa de exercícios.

O projeto segue boas práticas de design modular e inclui documentação interativa para facilitar a integração e o uso por parte de outros sistemas.

## Objetivos do Projeto
- Desenvolver uma API RESTful para gestão de receitas e exercícios.
- Implementar funcionalidades CRUD para os dois módulos.
- Garantir a persistência de dados utilizando uma base de dados relacional.
- Proteger a API através de autenticação com Bearer Token.
- Documentar e testar a API utilizando o Swagger.

## Estrutura de Pastas e Ficheiros
```plaintext
TP2/
├── API/
│   ├── Controllers/         # Controladores que gerem os endpoints
│   ├── Models/              # Modelos de dados (Receita, Exercício, etc.)
│   ├── Services/            # Serviços para lógica de negócio
│   ├── Data/                # Configuração da base de dados
│   ├── Program.cs           # Ponto de entrada da aplicação
│   └── appsettings.json     # Configurações da aplicação
├── doc/
│   ├── relatorio.docx       # Relatório provisório do projeto
│   ├── diagramas/           # Diagramas de arquitetura e fluxo
│   └── enunciado.pdf        # Enunciado do trabalho
└── README.md                # Este ficheiro
```

## Desenvolvimento Atual

### O que já está implementado:
1. **Modelos de Dados:**
   - Estrutura para representar receitas e exercícios.
   - Configuração inicial da base de dados relacional.

2. **Endpoints:**
   - `GET /recipes`: Recupera a lista de receitas.
   - `GET /exercises`: Recupera a lista de exercícios.

3. **Autenticação:**
   - Proteção da API com autenticação baseada em tokens Bearer.

4. **Documentação:**
   - Endpoints documentados no Swagger.

### O que falta desenvolver:
1. Adicionar endpoints para criar, atualizar e eliminar receitas e exercícios.
2. Implementar validações de dados nos modelos e controladores.
3. Integrar testes unitários e de integração.
4. Finalizar o mapeamento completo entre a base de dados e os serviços.

---

## Como Executar o Projeto

### Requisitos
- **.NET Core 6** ou superior.
- Base de dados configurada (exemplo: SQL Server).
- Ferramenta para testar API (exemplo: Postman ou cURL).

### Passos
1. **Clone o repositório:**
   ```bash
   git clone <URL-do-repositorio>
   ```

2. **Configure a base de dados:**
   - Atualize as configurações de conexão no ficheiro `appsettings.json`.

3. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

4. **Aceda ao Swagger:**
   - Abra o navegador e vá para `http://localhost:<porta>/swagger` para consultar a documentação interativa.


