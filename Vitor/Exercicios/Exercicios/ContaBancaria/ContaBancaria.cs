using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ContaBancaria
{
/**   
 * Problema:
 *  Crie uma classe ContaBancaria com: 
 *      Campos privados para número da conta, 
 *      saldo e senhaPropriedades públicas somente leitura para os campos
 *      Método público Sacar que verifica a senha antes de permitir o saque
 *      Construtor para inicializar os campos 
 */

    class ContaBancaria
    {
        private string _numeroConta;
        private decimal _saldo;
        private string _senha;
        private decimal _chequeEspecial;
        public string NumeroConta => _numeroConta;
        public decimal Saldo => _saldo;
        public ContaBancaria(string numeroConta, decimal saldoInicial, string senha)
        {
            _numeroConta = numeroConta;
            _saldo = saldoInicial;
            _senha = senha;
        }

        public bool Sacar(decimal valor, string senha)
        {
            if (senha != _senha) return false;
            if (valor > _saldo) return false;

            _saldo -= valor;
            return true;
        }
    }
}
