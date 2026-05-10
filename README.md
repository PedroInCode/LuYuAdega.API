# 🛒 ProCatalog.Ecommerce.API

> 🚧 **Status: Em Planejamento e Estruturação Base**
>
> Este projeto consiste em uma Web API de nível profissional para gerenciamento de um catálogo de E-commerce. O foco é aplicar padrões arquiteturais modernos do ecossistema .NET 9, garantindo escalabilidade e facilidade de manutenção.

---

## 🎯 Objetivo do Projeto
Desenvolver um sistema de catálogo que gerencie produtos e categorias, aplicando regras de negócio reais (validação de estoque, margem de lucro, filtros de busca) e utilizando uma arquitetura em camadas.

---

## 🏗️ O Plano de Execução (Roadmap)

Seguirei uma ordem lógica de desenvolvimento para garantir o entendimento total do fluxo de dados:

### Fase 1: Domínio e Persistência (The Foundation)
- [ ] **Definição de Models:** Criar as entidades `Produto` e `Categoria` com relacionamentos 1:N.
- [ ] **Data Context:** Configurar o Entity Framework Core e as Migrations.
- [ ] **Repository Layer (Opcional/Futuro):** Abstração do acesso a dados.

### Fase 2: Contratos e Comunicação (DTOs)
- [ ] **ProdutoDTOs:** Criar objetos separados para Criação (Input) e Resposta (Output).
- [ ] **Mapeamento:** Implementar a lógica de conversão entre Entidades e DTOs.

### Fase 3: Inteligência de Negócio (Services)
- [ ] **Interfaces:** Definir os contratos dos serviços.
- [ ] **ProdutoService:** Implementar lógica de:
  - Validação de estoque mínimo.
  - Cálculo de preço com base em regras de categoria.
  - CRUD completo isolado do Controller.

### Fase 4: Exposição da API (Controllers)
- [ ] **Endpoints:** Implementar as rotas HTTP seguindo os padrões RESTful.
- [ ] **Injeção de Dependência:** Configurar o ciclo de vida dos serviços no `Program.cs`.

### Fase 5: Documentação e Qualidade
- [ ] **Swagger/Scalar:** Configurar a interface de testes da API.
- [ ] **Global Exception Handling:** Criar um middleware para tratar erros de forma profissional.

---

## 🛠️ Tecnologias e Padrões
- **Linguagem:** C# (.NET 9)
- **Banco de Dados:** SQL Server (via EF Core)
- **Padrões:** Service Pattern, DTO Pattern, Injeção de Dependência.
- **Ferramentas:** Git, Git Bash, Visual Studio 2022.

---

## 👨‍💻 Autor
Desenvolvido por **PedroInCode**. 
*"O medo de falhar é o combustível para aprender o que é necessário."*