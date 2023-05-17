using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcidentesController : ControllerBase
    {
        
        private readonly ILogger<AcidentesController> _logger;

        public AcidentesController(ILogger<AcidentesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAcidentes")]
        public List<Acidente> Get()
        {   
            return mockAcidentes();
        }

        //TODO REMOVER MOCK
        private List<Acidente> mockAcidentes()
        {
            List<Acidente> acidentes = new List<Acidente>();

            acidentes.Add(mockAcidente(1));
            acidentes.Add(mockAcidente(2));
            acidentes.Add(mockAcidente(3));
            acidentes.Add(mockAcidente(4));

            return acidentes;
        }

        //TODO REMOVER MOCK
        private Acidente mockAcidente(int id)
        {
            Segurado segurado = new Segurado();
            segurado.Nome = "Antônio Gomes Ribeiro";
            segurado.Telefone = "(11) 7681-5230";
            segurado.Celular = "(11) 97681-5230";
            segurado.DataNascimento = DateTime.Now;
            segurado.Rg = "43.546.345-2";
            segurado.Cpf = "472.335.423-92";
            segurado.Endereco = "Rua Tres, 230";
            segurado.Cidade = "Rio de Janeiro";
            segurado.Estado = "RJ";
            segurado.Cep = "22733-086";

            Veiculo veiculo = new Veiculo();
            veiculo.Tipo = "Moto";
            veiculo.Modelo = "XPTO";
            veiculo.Marca = "YPTO";
            veiculo.Placa = "HPV-4526";
            veiculo.Ano = "2010/2011";

            Acidente acidente = new Acidente();
            acidente.Id = id;
            acidente.NomeSinistrado = "Antônio Gomes Ribeiro";
            acidente.Coordenadas = "-22,836251, -43,429802";
            acidente.Endereco = "Rua Quatro, 230";
            acidente.Cidade = "Rio de Janeiro";
            acidente.Estado = "RJ";
            acidente.Cep = "22733-090";
            acidente.Samu = "SIM";
            acidente.AssistenciaGuincho = "SIM";
            acidente.RedeApoio = "SIM";
            acidente.EnviadoOrientacaoSinistro = "SIM";
            acidente.Segurado = segurado;
            acidente.Veiculo = veiculo;

            return acidente;
        }
    }
}