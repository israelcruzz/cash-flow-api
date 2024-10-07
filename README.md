# 💸 *CashFlow*

![Logo do Projeto](https://github.com/israelcruzz/cash-flow-api/blob/main/thumb-cash-flow.png?raw=true) <!-- Substitua pelo link para o logo do seu projeto -->

## Descrição

O *CashFlow* é um sistema de gerenciamento financeiro que permite aos usuários controlar suas receitas e despesas de forma eficaz. Com uma arquitetura modular e escalável, o projeto foi desenvolvido utilizando as melhores práticas de desenvolvimento.

---

## 🏛️ Arquitetura do Projeto

* 🟢 **API Project**: Responsável por gerenciar as requisições e interações com o cliente.
* 🔵 **Communication Project**: Facilita a comunicação entre diferentes partes do sistema.
* 🟣 **Application Project**: Contém a lógica de aplicação e regras de negócios.
* 🟡 **Domain Project**: Define as entidades e a lógica de domínio do sistema.
* 🟤 **Infrastructure Project**: Lida com a persistência de dados e serviços externos.
* 🔴 **Exception Project**: Gerencia o tratamento de exceções e erros.

![Arquitetura do Projeto](https://github.com/user-attachments/assets/bebf7f7b-88d0-466f-bf16-9fc2fa471cd5) 

---

## 👀 Project Dependency Visibility

Aqui conseguimos enxergar a visibilidade entre os projetos.

| _Project_              | _Visibility 1_  | _Visibility 2_ | _Visibility 3_ | _Visibility 4_ | _Visibility 5_ |
|------------------------|-----------------|----------------|----------------|----------------|----------------|
| **API**                | Application     | Communication  | Exception      | Infrastructure |                |
| **Application**        | Communication   | Domain         | Exception      |                |                |
| **Communication**      |                 |                |                |                |                |
| **Domain**             |                 |                |                |                |                |
| **Exception**          |                 |                |                |                |                |
| **Infrastructure**     | Domain          |                |                |                |                |

---

## 🗃️ Estrutura do Projeto

```shell
.
├── CashFlow.sln
├── src
└── tests
