namespace WebApplication1.Model
{
    public class Acidente
    {
        public Acidente()
        {
            this.DataOcorrencia = DateTime.Now;
            this.AtendimentoAtivo = true;
        }
        public int Id { get; set; }
        public string NomeSinistrado { get; set; }
        public string Coordenadas { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Samu { get; set; }
        public string AssistenciaGuincho { get; set; }
        public string EnviadoOrientacaoSinistro { get; set; }
        public string RedeApoio { get; set; }
        public Segurado Segurado { get; set; }
        public Veiculo Veiculo { get; set; }
        public bool AtendimentoAtivo { get; set; }

    }
}
