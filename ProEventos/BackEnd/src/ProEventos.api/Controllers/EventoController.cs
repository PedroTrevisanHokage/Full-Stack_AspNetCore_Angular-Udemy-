using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular e DotNet 5",
                Local = "Ribeirão Preto",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(), 
                ImagemUrl = "foto.page"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Segundo Evento",
                Local = "Local Segundo Evento",
                Lote = "2º Lote",
                QtdPessoas = 30,
                DataEvento = DateTime.Now.AddDays(9).ToString(), 
                ImagemUrl = "foto2.page"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet]
        [Route("GetPorId/{id}")]
        public IEnumerable<Evento> Get(int id)
        {
           return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpGet("{id}")]
        public string Put(string id)
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(string id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }


}
