using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interface;

namespace DwUniSys.Test
{
    [TestClass]
    public class IClienteTest
    {
        [TestMethod]
        public void Endereco_QuandoObterEndereco_DeveRetornarEnderecoCompleto()
        {
            ICliente ICliente = new ICliente();
            ICliente.I2_LOGRADOURO = "RUA CORCOVADO";
            ICliente.I2_NUMERO = "702";
            ICliente.I2_BAIRRO = "NOVO RIACHO";
            ICliente.I2_MUN = "CONTAGEM";
            ICliente.I2_UF = "MG";

            string ResultadoEsperado = "RUA CORCOVADO 702, NOVO RIACHO - CONTAGEM / MG";

            string ResultadoReal = ICliente.I2_ENDERECO;

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void Endereco_QuandoObterEnderecoSemBairro_DeveRetornarEnderecoSemBairro()
        {
            ICliente ICliente = new ICliente();
            ICliente.I2_LOGRADOURO = "RUA CORCOVADO";
            ICliente.I2_NUMERO = "702";
            ICliente.I2_MUN = "CONTAGEM";
            ICliente.I2_UF = "MG";

            string ResultadoEsperado = "RUA CORCOVADO 702 - CONTAGEM / MG";

            string ResultadoReal = ICliente.I2_ENDERECO;

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void Endereco_QuandoObterLogradouroMunicipioUF_DeveRetornarEnderecoLogradouoMunicipioUF()
        {
            ICliente ICliente = new ICliente();
            ICliente.I2_LOGRADOURO = "RUA CORCOVADO";
            ICliente.I2_MUN = "CONTAGEM";
            ICliente.I2_UF = "MG";

            string ResultadoEsperado = "RUA CORCOVADO - CONTAGEM / MG";

            string ResultadoReal = ICliente.I2_ENDERECO;

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void Endereco_QuandoObterEndereçoMunicipioUF_DeveRetornarEnderecoMunicipioUF()
        {
            ICliente ICliente = new ICliente();
            ICliente.I2_MUN = "CONTAGEM";
            ICliente.I2_UF = "MG";

            string ResultadoEsperado = "CONTAGEM / MG";

            string ResultadoReal = ICliente.I2_ENDERECO;

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }
    }
}
