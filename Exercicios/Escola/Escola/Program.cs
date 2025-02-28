using Escola.Classes;

Aluno aluno1 = new Aluno();
aluno1.Nome = "Robert";
aluno1.Idade = 15;
aluno1.Notas = [7, 5, 8];

Professor professor1 =  new Professor();
professor1.Nome = "Andre";

Disciplina disciplina1 = new Disciplina();
disciplina1.Nome = "Portugues";

professor1.AdicionarDisciplina(disciplina1);
disciplina1.AdicionarAluno(aluno1);

professor1.ExibirDadosProfessora();
aluno1.ExibirDadosAluno();
disciplina1.ExibirDadosDisciplina();