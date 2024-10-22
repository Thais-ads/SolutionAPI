## Descrição do ContatoController
O ContatoController é um componente da API que gerencia as operações relacionadas aos contatos em uma agenda. Ele utiliza o padrão de arquitetura MVC (Model-View-Controller) e é construído sobre o ASP.NET Core. O controlador fornece uma série de métodos que permitem realizar operações CRUD (Criar, Ler, Atualizar e Deletar) sobre os contatos armazenados no banco de dados.

Funcionalidades
Criar Contato:

O método Create permite adicionar um novo contato à agenda. Ele aceita um objeto do tipo Contato, que contém informações como nome e telefone. Após adicionar o contato, a operação é salva no banco de dados e o contato criado é retornado na resposta.
Buscar Contato por ID:

O método BuscarContato permite buscar um contato específico utilizando seu ID. Se o contato for encontrado, suas informações são retornadas; caso contrário, retorna um status de 404 Not Found.
Buscar Todos os Contatos:

O método BuscarTodosContato retorna uma lista de todos os contatos armazenados na agenda. É útil para visualizar todos os registros de uma vez.
Buscar Contato por Nome:

O método BuscarcontatoNome permite buscar contatos cujo nome contenha uma string específica. Isso possibilita uma busca mais dinâmica e flexível por contatos.
Atualizar Contato:

O método AtualizarContato permite modificar as informações de um contato existente. Ele procura o contato pelo ID, atualiza seus dados conforme o objeto fornecido e salva as alterações no banco de dados. Se o contato não for encontrado, retorna um status de 404 Not Found.
Apagar Contato:

O método ApagarContato permite remover um contato da agenda pelo seu ID. Se o contato for encontrado e removido com sucesso, a operação retorna um status de 200 OK; se o contato não existir, retorna um status de 204 No Content.
Estrutura e Dependências
O controlador depende do contexto do Entity Framework (AgendaContext), que gerencia as operações de acesso ao banco de dados. O controlador é anotado com [ApiController], que permite que ele trate automaticamente algumas tarefas comuns de controle de API, como validação de modelos.

O ContatoController é uma parte fundamental do sistema, pois fornece uma interface clara e acessível para gerenciar os contatos de forma eficaz, facilitando a integração com outras partes da aplicação ou serviços externos.

Você pode ajustar o texto conforme necessário para se adequar ao estilo e ao conteúdo do seu README!
