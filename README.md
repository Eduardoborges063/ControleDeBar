Este projeto tem como objetivo gerenciar mesas, garçons, produtos e contas de pedidos de um restaurante. Ele é dividido em módulos independentes, mas que se relacionam entre si através de regras de negócio bem definidas.

O sistema permite cadastro, edição, exclusão e visualização de informações, além de controle completo das contas (pedidos) dos clientes.

🧩 1. Módulo de Mesas
✅ Requisitos Funcionais

Inserir novas mesas

Editar mesas cadastradas

Excluir mesas cadastradas

Visualizar lista de mesas

Visualizar detalhes de uma mesa específica

Exibir status da mesa (Livre / Ocupada)

📌 Regras de Negócio

Campos obrigatórios:

Número: único e positivo

Quantidade de Lugares: número positivo

Status possíveis: Livre ou Ocupada

Status padrão ao cadastrar: Livre

Não permitir números duplicados

Não permitir excluir mesa com pedidos vinculados

🧑‍🍳 2. Módulo de Garçons
✅ Requisitos Funcionais

Inserir novos garçons

Editar garçons cadastrados

Excluir garçons cadastrados

Visualizar lista de garçons

📌 Regras de Negócio

Campos obrigatórios:

Nome: mínimo 3, máximo 100 caracteres

CPF: formato válido (XXX.XXX.XXX-XX)

Não permitir cadastro com CPF duplicado

Não permitir nome + CPF duplicados

Não permitir excluir garçom com pedidos vinculados

🛒 3. Módulo de Produtos
✅ Requisitos Funcionais

Inserir novos produtos

Editar produtos cadastrados

Excluir produtos cadastrados

Visualizar lista de produtos

📌 Regras de Negócio

Campos obrigatórios:

Nome: mínimo 2, máximo 100 caracteres

Preço: valor positivo com 2 casas decimais

Não permitir excluir produtos com pedidos vinculados

Não permitir nome duplicado

🧾 4. Módulo de Conta (Pedidos)
✅ Requisitos Funcionais

Abrir contas para clientes realizarem pedidos

Adicionar itens em um pedido existente

Remover itens de um pedido existente

Visualizar faturamento diário

Visualizar contas em aberto

Visualizar contas fechadas

Fechar contas/pedidos

📌 Regras de Negócio

Campos obrigatórios ao abrir conta:

Nome do cliente

Mesa (selecionada entre as cadastradas)

Garçom (selecionado entre os cadastrados)

Campos obrigatórios ao registrar pedidos:

Lista de itens (produtos + quantidade)

Status possíveis: Aberta ou Fechada

Status padrão ao abrir conta: Aberta

O sistema deve:

Calcular automaticamente o total de cada pedido

Calcular o faturamento total do dia

Cada mesa só pode ter uma conta aberta por vez

🧱 Estrutura Recomendada do Sistema

Módulos separados por responsabilidade

Validações centralizadas por entidade

Regras de negócio aplicadas nos serviços

Persistência organizada por repositórios
