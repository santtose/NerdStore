# Projeto NerdStore - Modelando Domínios Ricos do curso Desenvolvedor.io

É um sistema simples de e-comerce orientada a eventos, onde é possível adicionar itens ao estoque que serão disponibilizados para venda, onde o usuário pode escolher os produtos, e enviá-los para um carrinho,
onde é possível adicionar vouchers de desconto, atualizar quantidade, deletar um pedido do carrinho, em fim, o básico de um e-comerce real, inclusive a parte de pagamento, que no caso do projeto é de
forma simulada com PayPalGateway onde é possível concluir o pagamento ou a compra ser recusada.
Sendo possível visualizar um histórico de eventos dos pedidos finalizados (pagos).
A interface é simples, é um projeto básico MVC, com o intuito de facilitar a visualização e entendimento dos testes e funcionamento do sistema em si.

## Alguns dos temas/princípios abordados:
- DDD
- SOLID
- CQRS
- Patterns
- Unit
- Event Sourcing com Evento Store

Para rodar o projeto:
- Dar o start no projeto NerdStore.WebApp.MVC
- Update-Database -Context {NomeContexto}. Apontando para o projeto onde o contexto está, os três contextos implementados são:
  - CatalogoContext
  - VendasContext
  - PagamentoContext
