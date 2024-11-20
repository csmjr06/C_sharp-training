using System.Globalization;

namespace Exe02_POO_Methods {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto *= (1 + (porcentagem / 100));
        }

        override public string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
