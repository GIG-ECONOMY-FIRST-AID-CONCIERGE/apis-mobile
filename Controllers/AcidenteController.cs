using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcidenteController : ControllerBase
    {
        
        private readonly ILogger<AcidenteController> _logger;

        public AcidenteController(ILogger<AcidenteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAcidente")]
        public Acidente Get(int id)
        {
            if (id == 1)
                return mockAcidente(1);
            if (id == 2)
                return mockAcidente(2);
            if (id == 3)
                return mockAcidente(3);

            return mockAcidente(1);
        }

        [HttpPost(Name = "PostAcidente")]
        public bool Post(Acidente acidente)
        {
            if (acidente == null)
                return false;
            
            return true;
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