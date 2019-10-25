using POCAttribute.Models.ElementAttribute;

namespace POCAttribute.Models
{
    class Empregado
    {
        [EmpregadoAttribute(0, 1, 50, true)]
        public string Nome { get; set; }

        [EmpregadoAttribute(0, 1, 8, true)]
        public string Matricula { get; set; }

        [EmpregadoAttribute(0, 1, 8, true)]
        public string DataNascimento { get; set; }
    }
}
