using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controlador = null;
        ControladorContato controladorContato = null;
        public ControladorCompromissoTest()
        {
            controlador = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
            Db.Update("DELETE FROM [TBTAREFA]");
        }



        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            //arrange
            var contato = new Contato("José Pedro", "jose.pedro@gmail", "321654987", "JP Ltda", "Desenvolvedor");

            controladorContato.InserirNovo(contato);

            var novoCompromisso = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), controladorContato.SelecionarPorId(contato.Id));

            //action
            controlador.InserirNovo(novoCompromisso);

            //assert
            var contatoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            var novoCompromisso = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            //action
            controlador.InserirNovo(novoCompromisso);

            //assert
            var contatoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveEditar_Compromisso()
        {
            //arrange
            var compromisso = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2022, 10, 10), new TimeSpan(13, 00, 00), new TimeSpan(14, 30, 00), null);

            //action
            controlador.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);

        }

        [TestMethod]

        public void DeveExcluir_UmCompromisso()
        {
            //arrange            
            var novoCompromisso = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(novoCompromisso);

            ////action    
            controlador.Excluir(novoCompromisso.Id);

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            var novoCompromisso = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(novoCompromisso);

            //actiom
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);

            //assert
            compromissoEncontrado.Should().Be(novoCompromisso);

        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            var c1 = new Compromisso("Negocios", "Casa", "meet.com",
                 new DateTime(2002, 02, 23), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(c1);

            var c2 = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2021, 09, 12), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c2);

            var c3 = new Compromisso("Lavar louça", "Cozinha", "Presencial",
               new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c3);


            //action
            var compromissos = controlador.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("Negocios");
            compromissos[1].Assunto.Should().Be("Jantar");
            compromissos[2].Assunto.Should().Be("Lavar louça");
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos_Passados()
        {
            //arrange

            //passado
            var c1 = new Compromisso("Negocios", "Casa", "meet.com",
                 new DateTime(2002, 02, 23), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(c1);

            //futuro
            var c2 = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2021, 09, 12), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c2);

            //futuro
            var c3 = new Compromisso("Lavar louça", "Cozinha", "Presencial",
               new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c3);

            //passado
            var c4 = new Compromisso("Lavar Carro", "Cozinha", "Presencial",
               new DateTime(2020, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c4);

            //passado
            var c5 = new Compromisso("Jogar Fut", "Cozinha", "Presencial",
               new DateTime(2018, 08, 20), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c5);

            //action
            var compromissosPassados = controlador.SelecionarCompromissosPassados(new DateTime(2021, 09, 10));

            //assert
            compromissosPassados.Should().HaveCount(3);
            compromissosPassados[0].Assunto.Should().Be("Negocios");
            compromissosPassados[1].Assunto.Should().Be("Lavar Carro");
            compromissosPassados[2].Assunto.Should().Be("Jogar Fut");
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos_Futuros()
        {
            //arrange

            //passado
            var c1 = new Compromisso("Negocios", "Casa", "meet.com",
                 new DateTime(2002, 02, 23), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(c1);

            //futuro
            var c2 = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2021, 09, 12), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c2);

            //futuro
            var c3 = new Compromisso("Lavar louça", "Cozinha", "Presencial",
               new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c3);

            //passado
            var c4 = new Compromisso("Lavar Carro", "Cozinha", "Presencial",
               new DateTime(2020, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c4);

            //passado
            var c5 = new Compromisso("Jogar Fut", "Cozinha", "Presencial",
               new DateTime(2018, 08, 20), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c5);

            //futuro
            var c6 = new Compromisso("Comprar coca", "Cozinha", "Presencial",
               new DateTime(2025, 08, 20), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);
            controlador.InserirNovo(c6);

            DateTime dataInicio = DateTime.Now;
            DateTime dataFim = new DateTime(2024, 08, 09);

            //action
            var compromissosFuturos = controlador.SelecionarCompromissosFuturos(dataInicio, dataFim);

            //assert
            compromissosFuturos.Should().HaveCount(2);
            compromissosFuturos[0].Assunto.Should().Be("Jantar");
            compromissosFuturos[1].Assunto.Should().Be("Lavar louça");

        }

        [TestMethod]
        public void NaoDeveInserir_NaMesmaData_NoMesmoHorario()
        {
            //arrange 
            Compromisso compromisso = new Compromisso("Negocios", "Casa", "meet.com",
                 DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(13, 00, 00), null);

            controlador.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Jantar", "Sala", "Presencial",
                DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(13, 00, 00), null);

            //action
            string resultado = controlador.InserirNovo(novoCompromisso);

            //assert
            resultado.Should().Be("Nesta data e horário já tem um compromisso cadastrado");

            List<Compromisso> compromissos = controlador.SelecionarTodos();
            compromissos.Should().HaveCount(1);


        }

        [TestMethod]
        public void NaoDeveEditar_NaMesmaData_NoMesmoHorario()
        {
            //arrange 
            Compromisso compromisso = new Compromisso("Negocios", "Casa", "meet.com",
                 DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(13, 00, 00), null);

            controlador.InserirNovo(compromisso);

            //action
            var novoCompromisso = new Compromisso("Jantar", "Sala", "Presencial",
               DateTime.Today, new TimeSpan(12, 00, 00), new TimeSpan(13, 00, 00), null);

            string resultado = controlador.Editar(compromisso.Id, novoCompromisso);

            //assert
            resultado.Should().Be("Nesta data e horário já tem um compromisso cadastrado");

        }

        [TestMethod]
        public void DeveEditar_Compromisso_RemovendoContato()
        {
            //arrange
            Contato c = new Contato("Lucas", "lucas@lucas.com", "12345678", "ndd", "dev");
            controladorContato.InserirNovo(c);
            
            var compromissoComContato = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), controladorContato.SelecionarPorId(c.Id));

            controlador.InserirNovo(compromissoComContato);

            var novoCompromisso = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2021, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            //action
            controlador.Editar(compromissoComContato.Id, novoCompromisso);

            //assert
            var contatoEncontrado = controlador.SelecionarPorId(compromissoComContato.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveEditar_Compromisso_InserindoContato()
        {
            //arrange
            var compromissoComContato = new Compromisso("Negocios", "Casa", "meet.com",
                new DateTime(2022, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), null);

            controlador.InserirNovo(compromissoComContato);

            Contato c = new Contato("Lucas", "lucas@lucas.com", "12345678", "ndd", "dev");
            controladorContato.InserirNovo(c);

            var novoCompromisso = new Compromisso("Jantar", "Sala", "Presencial",
                new DateTime(2021, 10, 10), new TimeSpan(12, 00, 00), new TimeSpan(12, 30, 00), controladorContato.SelecionarPorId(c.Id));

            //action
            controlador.Editar(compromissoComContato.Id, novoCompromisso);

            //assert
            var contatoEncontrado = controlador.SelecionarPorId(compromissoComContato.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

    }
}
