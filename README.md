# Palestra

1) Como Rodar a aplicação:
  - Após clonar o repositório do git abre o projeto clicando duas vezes em Palestra.sln.
  - Assim e a aplicação abrir no visual studio clique em "Iniciar" e a lista final será mostrada no console.
  
2) Como rodar os unittests:
  - No projeto UnitTestProject1 abra o arquivo UnitTest1.cs no visual studio
  - Clique com o botao direito no nome da classe e em seguida clique em "executar todos os testes'.
  
3) Conteudos relevantes:
  - Classes:
      - Palestrante: Contém a classe que define uma palestra pelos atributos name(String - nome da palestra e palestrante),
          time(int, tempo em minutos da palestra), alocation(boolean, define se uma palestra está alocada - true ou não - false).
      - Agenda: Contém os metodos para gerar uma agenda:
            - criarAgenda: recebe days(int - quantos dias ocorrerão os eventos, turn (int - quantos turnos possuem um dia de evento,
            ex: manhã, tarde), turnTimes(int[] - array de quanto tempp dura um turno, respecivamente), list(lista de palestras)
            primeiro ordena a agenda do maior tempo de palestra para o menor, assim garante ocupar melhor o tempo de cada turno.
            enquanto há eventos não marcados e turnos com tempo, aloca palestras.
            - showAgenda - mostra a saida no console.
            - DesmarcarTodos - seta todas as palestras "alocation" para false.
       - UnitTest1: classe com os unit tests do projeto.
