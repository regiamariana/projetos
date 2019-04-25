namespace Senaizinho_2_Tarde {
    public class Sala {
        public int NumeroSala {get; private set;}
        public int CapacidadeAtual{get; set;}
        public int CapacidadeTotal{get; set;}
        public Aluno[] Alunos{get; set;}

        public string AlocarAluno (string NomeAluno) {
            if (CapacidadeAtual > 0) {
                CapacidadeAtual--;
                for (int i = 0; i < alunos.Length; i++) {
                    if (alunos[i] == null) 
                    {
                        alunos[i] = NomeAluno;
                        return $"Aluno {NomeAluno} alocado com sucesso!";
                    }    
                }
            } else {
                return $"Capacidade da sala {NumeroSala} excedida!";
            }
            return "Não foi possível cadastrar";
        }
                public Sala(int numeroSala, int CapacidadeTotal){
                        this.NumeroSala = NumeroSala;
                        this.CapacidadeAtual = CapacidadeAtual;
                        this.CapacidadeTotal = CapacidadeTotal;
                }
        public string RemoverAluno (string nomeAluno, out string mensagem ) {
            for (int i = 0; i < alunos.Length; i++) {
                if (alunos[i] != null && nomeAluno.Equals (alunos[i])) {
                    alunos[i] = null;
                    capacidadeAtual++;
                    mensagem = $"Aluno {nomeAluno} removido com sucesso!";
                }
            }
            return $"{nomeAluno} não foi encontrado";
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

    }
}