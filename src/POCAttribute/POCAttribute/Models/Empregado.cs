using POCAttribute.Models.ElementAttribute;
using System;
using System.Reflection;

namespace POCAttribute.Models
{
    class Empregado
    {
        public Empregado(string line)
        {
            Type classType = typeof(Empregado);
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                EmpregadoAttribute attribute = (EmpregadoAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(EmpregadoAttribute));

                classType.GetProperty(propertyInfo.Name).SetValue(this, line.Substring(attribute.InitialPosition, attribute.Length).Trim());
            }
        }

        
        [EmpregadoAttribute(0, 1, true)]
        public string Grupo { get; set; }

        [EmpregadoAttribute(1, 3, true)]
        public string CodEmpresa { get; set; }

        [EmpregadoAttribute(4, 10, true)]
        public string Registro { get; set; }

        [EmpregadoAttribute(14, 50, true)]
        public string Nome { get; set; }

        [EmpregadoAttribute(64, 11, true)]
        public string CPF { get; set; }

        [EmpregadoAttribute(75, 15, true)]
        public string RG { get; set; }

        [EmpregadoAttribute(90, 6, true)]
        public string RGOrgaoExpedidor { get; set; }

        [EmpregadoAttribute(96, 5, false)]
        public string OrgaoLotaco { get; set; }

        [EmpregadoAttribute(101, 10, true)]
        public DateTime DataNascimento { get; set; }

        [EmpregadoAttribute(111, 2, true)]
        public string SituacaoPatrocinador { get; set; }

        [EmpregadoAttribute(113, 1, true)]
        public int CodEstadoCivil { get; set; }

        [EmpregadoAttribute(111, 50, true)]
        public string Pai { get; set; }

        [EmpregadoAttribute(111, 50, true)]
        public string Mae { get; set; }

        [EmpregadoAttribute(111, 1, true)]
        public char Sexo { get; set; }

        [EmpregadoAttribute(111, 80, true)]
        public string Endereco { get; set; }

        [EmpregadoAttribute(111, 25, true)]
        public string Bairro { get; set; }

        [EmpregadoAttribute(111, 40, true)]
        public string Cidade { get; set; }

        [EmpregadoAttribute(111, 2, true)]
        public string UF { get; set; }

        [EmpregadoAttribute(111, 8, true)]
        public string CEP { get; set; }

        [EmpregadoAttribute(111, 4, true)]
        public string DDDTelefone { get; set; }

        [EmpregadoAttribute(111, 25, true)]
        public string Telefone { get; set; }

        [EmpregadoAttribute(111, 10, true)]
        public string DataInscricao { get; set; }

        [EmpregadoAttribute(111, 3, true)]
        public string Banco { get; set; }

        [EmpregadoAttribute(111, 7, true)]
        public string Agencia { get; set; }

        [EmpregadoAttribute(111, 15, true)]
        public string ContaCorrente { get; set; }

        [EmpregadoAttribute(111, 30, true)]
        public string Nacionalidade { get; set; }

        [EmpregadoAttribute(111, 4, false)]
        public string Ramal { get; set; }

        [EmpregadoAttribute(111, 15, true)]
        public string Salario { get; set; }

        [EmpregadoAttribute(111, 50, false)]
        public string Email { get; set; }

        [EmpregadoAttribute(111, 25, false)]
        public string Celular { get; set; }

        [EmpregadoAttribute(111, 4, false)]
        public string DDDCelular { get; set; }

        [EmpregadoAttribute(111, 10, true)]
        public string DataAdmissao { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public string DataAfastamento { get; set; }

        [EmpregadoAttribute(111, 10, true)]
        public string DtInicioAlteracaoSituacao { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public string DataDemissao { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public string DataDesligamentoPlano { get; set; }

        [EmpregadoAttribute(111, 2, true)]
        public string CodMotivoDemissao { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public string DataObito { get; set; }

        [EmpregadoAttribute(111, 1, false)]
        public int? CodConfidencialidade { get; set; }

        [EmpregadoAttribute(111, 1, true)]
        public int CodContratoTrabalho { get; set; }

        [EmpregadoAttribute(111, 100, false)]
        public string CodEstrutural { get; set; }

        [EmpregadoAttribute(111, 10, true)]
        public DateTime RGDataExpedicao { get; set; }

        [EmpregadoAttribute(111, 14, true)]
        public string PercentualContribuicao { get; set; }

        [EmpregadoAttribute(111, 3, true)]
        public string Plano { get; set; }

        [EmpregadoAttribute(111, 15, false)]
        public string ContribuicaoEsporadica { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public DateTime DataInicio { get; set; }

        [EmpregadoAttribute(111, 10, false)]
        public DateTime DataFim { get; set; }

        [EmpregadoAttribute(111, 30, true)]
        public string Livre { get; set; }
    }
}