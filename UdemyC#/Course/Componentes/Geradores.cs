using System.Text;

namespace Componentes
{
    public class Geradores
    {
        public static string GerarCPF()
        {

            string baseNumbers = "9274806351";
            StringBuilder cpfGerado = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 11; i++)
            {
                int index = random.Next(baseNumbers.Length);
                cpfGerado.Append(baseNumbers[index]);
            }

            cpfGerado.Insert(3, ".").Insert(7, ".").Insert(11, "-");

            return cpfGerado.ToString();

        }
    }
}
