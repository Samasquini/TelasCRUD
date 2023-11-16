using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telaCRUD
{
    public static class ValidarCPF
    {
        public static bool ValidaCpf(string cpf)
        {
            string cpf_Ver = cpf.Replace(".", "").Replace("-", "").Replace(",","");
            int[] num_cpf_Ver = new int[cpf_Ver.Length];
            for (int i = 0; i <= 10; i++)
            {
                num_cpf_Ver[i] = int.Parse(cpf_Ver[i].ToString());
            }
            bool verificador2 = false, verificador1 = false;
            int soma = 0, result = 0;
            if (cpf_Ver.Length == 11)
            {
                //Verificador 1
                for (int i = 0, j = 10; i <= 8; i++, j--)
                {
                    soma += int.Parse(num_cpf_Ver[i].ToString()) * j;
                }
                result = soma % 11;
                if (result < 2)
                {
                    if (num_cpf_Ver[9] == 0)
                        verificador1 = true;
                }
                else if (result >= 2)
                {
                    if ((num_cpf_Ver[9] == (11 - result)))
                        verificador1 = true;
                }
                //Verificador 2
                soma = 0;
                result = 0;
                for (int i = 0, j = 11; i <= 9; i++, j--)
                {
                    soma += int.Parse(num_cpf_Ver[i].ToString()) * j;
                }
                result = soma % 11;
                if (result < 2)
                {
                    if (num_cpf_Ver[10] == 0)
                        verificador2 = true;
                }
                else if (result >= 2)
                {
                    if ((num_cpf_Ver[10] == (11 - result)))
                        verificador2 = true;
                }
            }
            if (verificador1 && verificador2)
                return true;
            else
                return false;
        }
    }
}
