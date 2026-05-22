# 🍷 LuYu Adega - Web API 

> 🚀 **Status: Em Planejamento e Estruturação Base**
>
> Este repositório é um ambiente de treino individual voltado ao desenvolvimento de uma **Web API de nível profissional utilizando .NET 9 e C#**. O objetivo é aplicar padrões arquiteturais modernos de mercado para resolver problemas reais de lógica de negócio e persistência de dados de um comércio de bebidas (Adega LuYu).

---

## 🎯 Objetivo da API

O propósito central desta API é centralizar toda a inteligência de negócios do ecossistema da adega, garantindo que regras críticas sejam processadas em um único lugar. O projeto serve como um laboratório prático para treinar o desacoplamento de software, preparando o backend para suportar e unificar dados de futuras frentes (como um sistema Desktop em Windows Forms, painéis Web ou aplicativos móveis).

### 🧠 Desafios de Negócio a serem Resolvidos (Regras da LuYu):
* **Controle de Estoque Inteligente:** Validação rigorosa de quantidades físicas disponíveis antes de processar qualquer venda ou pedido.
* **Mecanismo de Alerta de Estoque Mínimo:** Monitoramento em tempo real para disparar avisos quando o estoque atingir o limite crítico definido.
* **Padronização de Bebidas:** Gerenciamento técnico de propriedades específicas desse nicho, como controle por volume/litragem (ml/L) e preços estruturados.

---

## 🏗️ O Plano de Execução

O desenvolvimento seguirá uma ordem lógica e profissional, dividida em camadas de responsabilidade:

### Fase 1: Domínio e Persistência (The Foundation)
- [ ] **Modelagem das Entidades:** Criar as classes de domínio (`Produto`, `Categoria`, `Venda`, `ItemVenda`, `Usuario`, `Cliente`, `Fornecedor`).
- [ ] **Data Context (EF Core):** Configurar o Entity Framework Core com suporte a Migrations para mapeamento do banco de dados relacional (MariaDB ou SQL Server).

### Fase 2: Contratos e Comunicação (DTOs)
- [ ] **Data Transfer Objects (DTOs):** Implementar objetos separados para Entrada (Inputs de cadastro) e Saída (Respostas), isolando o banco de dados e ocultando dados sensíveis (como hashes de senhas).
- [ ] **Mapeamento:** Desenvolver a lógica de conversão entre entidades de banco e DTOs.

### Fase 3: Inteligência de Negócio (Services)
- [ ] **Service Pattern & Interfaces:** Isolar completamente as regras de validação, cálculos e operações de CRUD fora dos Controllers, criando um código altamente testável.

### Fase 4: Exposição dos Endpoints (Controllers)
- [ ] **Rotas HTTP RESTful:** Criar os controladores para expor os endpoints padronizados da API (ex: `/api/produtos`, `/api/vendas`).
- [ ] **Injeção de Dependência:** Configurar o ciclo de vida dos serviços no `Program.cs`.

### Fase 5: Documentação e Qualidade
- [ ] **Interface do Swagger:** Configurar o Swagger/OpenAPI para documentar e testar visualmente todas as rotas da API.
- [ ] **Global Exception Handling:** Criar um middleware customizado para capturar erros e padronizar as respostas JSON da API.

---

## 🛠️ Tecnologias e Padrões Aplicados
* **Linguagem & Plataforma:** C# (.NET 9)
* **ORM:** Entity Framework Core
* **Banco de Dados:** Compatibilidade configurada para MariaDB / SQL Server
* **Padrões de Projeto:** Service Pattern, DTO Pattern, Fluent API, Injeção de Dependência (DI) e Métodos de Extensão.

---

## 👨‍💻 Desenvolvedor
Projeto de estudo prático desenvolvido por **PedroInCode**.  
*"O medo de falhar é o combustível para aprender o que é necessário."*
