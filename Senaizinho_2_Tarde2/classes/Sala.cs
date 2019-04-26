namespace Senaizinho_2_Tarde {
    public class Sala {
        public int NumeroSala {get; private set;}
        public int CapacidadeAtual {get; private set;}
        public int CapacidadeTotal {get;}
        public Aluno[] Alunos {get;}

        public Sala(int numeroSala, int capacidadeTotal) {
            this.NumeroSala = numeroSala;
            this.CapacidadeTotal = capacidadeTotal;
            this.CapacidadeAtual = capacidadeTotal;
            this.Alunos = new Aluno[capacidadeTotal];
        }

        public bool AlocarAluno (Aluno aluno, out string mensagem) {
            if (CapacidadeAtual > 0) {
                CapacidadeAtual--;
                for (int i = 0; i < Alunos.Length; i++) {
                    if (Alunos[i] == null) 
                    {
                        Alunos[i] = aluno;
                        mensagem = $"Aluno {aluno.Nome} alocado com sucesso!";
                        return true;
                    }    
                }
            }
            mensagem = $"Capacidade da sala {NumeroSala} excedida!";
            return false;
        }

        public bool RemoverAluno (string nomeAluno, out string mensagem) {
            if (this.CapacidadeAtual > 0) {
                for (int i = 0; i < Alunos.Length; i++) {
                    if (Alunos[i] != null && nomeAluno.Equals (Alunos[i].Nome)) {
                        Alunos[i] = null;
                        CapacidadeAtual++;
                        mensagem = $"Aluno {nomeAluno} removido com sucesso!";
                        return true;
                    }
                }
                mensagem = $"{nomeAluno} não foi encontrado";
                return false;
            }
            mensagem = "Não há aluno aqui!";
            return false;
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in Alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

    }
}