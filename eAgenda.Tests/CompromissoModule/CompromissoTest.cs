using eAgenda.Dominio.CompromissoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveCriarCompromissoPresencial()
        {
            //action
            Compromisso compromisso = new Compromisso("Preparar aula", "Lages", "Presencial", DateTime.Today, new TimeSpan(14, 00, 00), new TimeSpan(15, 00, 00), null);

            //assert
            compromisso.Assunto.Should().Be("Preparar aula");
            compromisso.Local.Should().Be("Lages");
            compromisso.Data.Should().Be(DateTime.Today);
            compromisso.HoraInicio.Should().Be(new TimeSpan(14, 00, 00));
            compromisso.HoraTermino.Should().Be(new TimeSpan(15, 00, 00));
            compromisso.Contato.Should().BeNull();
        }

        [TestMethod]
        public void DeveCriarCompromissoRemoto()
        {
            //action
            Compromisso compromisso = new Compromisso("Comer maçã", "Remoto", "meet.com", DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), null);

            //assert
            compromisso.Assunto.Should().Be("Comer maçã");
            compromisso.Local.Should().Be("Remoto");
            compromisso.Data.Should().Be(DateTime.Today);
            compromisso.HoraInicio.Should().Be(new TimeSpan(12, 00, 00));
            compromisso.HoraTermino.Should().Be(new TimeSpan(16, 00, 00));
            compromisso.Contato.Should().BeNull();
        }

        [TestMethod]
        public void DeveCriarCompromissoComContato()
        {
            //action
            Contato contato = new Contato("Lucas", "lucas@lucas.com", "1234567", "ndd", "dev");
            Compromisso compromisso = new Compromisso("Comer maçã", "Remoto", "meet.com", DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), contato);

            //assert
            compromisso.Assunto.Should().Be("Comer maçã");
            compromisso.Local.Should().Be("Remoto");
            compromisso.Data.Should().Be(DateTime.Today);
            compromisso.HoraInicio.Should().Be(new TimeSpan(12, 00, 00));
            compromisso.HoraTermino.Should().Be(new TimeSpan(16, 00, 00));
            compromisso.Contato.Should().Be(contato);
        }

        [TestMethod]
        public void DeveRetornar_CompromissoValido()
        {
            //arrange
            Compromisso compromisso = new Compromisso("Comer maçã", "Lages", "Presencial", DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), null);


            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("ESTA_VALIDO");
        }

        [TestMethod]
        public void DeveValidar_Assunto()
        {
            //arrange
            var compromisso = new Compromisso("", "Lages", "Presencial", DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Data()
        {
            //arrange
            var compromisso = new Compromisso("Opa", "Lages", "Presencial", DateTime.MinValue, new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Data é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_HoraInicio()
        {
            //arrange
            var compromisso = new Compromisso("Opa", "Lages", "Presencial", DateTime.Today, TimeSpan.MinValue, new TimeSpan(16, 00, 00), null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Hora Início é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_HoraFim()
        {
            //arrange
            var compromisso = new Compromisso("Opa", "Lages", "Presencial", DateTime.Today, new TimeSpan(16, 00, 00), TimeSpan.MinValue, null);

            //action
            var resultado = compromisso.Validar();

            //assert
            resultado.Should().Be("O campo Hora Término é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_Assunto_Data_HoraF_HoraT()
        {
            //arrange
            var compromisso = new Compromisso("", "Lages", "Presencial", DateTime.MinValue, TimeSpan.MinValue, TimeSpan.MinValue, null);

            //assert
            var resultadoEsperado =
                "O campo Assunto é obrigatório"
                + Environment.NewLine
                + "O campo Data é obrigatório"
                + Environment.NewLine
                + "O campo Hora Início é obrigatório"
                + Environment.NewLine
                + "O campo Hora Término é obrigatório";

            //action
            var resultado = compromisso.Validar();

            resultado.Should().Be(resultadoEsperado);
        }

    }
}
