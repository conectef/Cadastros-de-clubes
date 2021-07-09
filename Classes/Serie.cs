namespace DIO.Clubes
{
    public class Clube : EntidadeBase
    {
        // Atributos

        private Time Time { get; set; }
        private int Fundacao { get; set; }
        private string Artilheiro { get; set; }
        private string Tecnico { get; set; }
        private string Cores { get; set; }

        //Métodos

        public Clubes(int id, Time Time, int Fundacao, string Artilheiro, string Tecnico, string Cores)
        {
            this.Id = id;
            this.Time = time;
            this.Fundacao = fundacao;
            this.Artilheiro = artilheiro;
            this.Tecnico = tecnico;
            this.Cores = cores;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome do clube: " + this.Time + Environment.NewLine;
            retorno += "Artilheiro: " + this.Artilheiro + Environment.NewLine;
            retorno += "Tecnico atual: " + this.Tecnico + Environment.NewLine;
            retorno += "Cores do clube: " + this.Cores + Environment.NewLine;
            retorno += "Ano de Fundação: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public int retornaId()
        {
            return this.Id;
        }
    }

}