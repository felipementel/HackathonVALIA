using POCAttribute.Models.ElementAttribute;
using System;
using System.Reflection;
using System.Web.Mvc;

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

        
        [EmpregadoAttribute(0, 50, true)]
        public string Nome { get; set; }

        [EmpregadoAttribute(50, 8, true)]
        public string Matricula { get; set; }

        [EmpregadoAttribute(58, 10, true)]
        public string DataNascimento { get; set; }
    }
}
