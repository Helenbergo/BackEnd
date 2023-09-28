using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
    //Criando a classe TarefaController e herdando seus métodos de Controller
    public class TarefaController : Controller
    {
        //Criando um objeto _tarefas que armazenará uma lista de tarefas
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }

        //Criando o método GET para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //Verificando o total de tarefas e somando +1 para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //Adicionando minha nova tarefa à lista
            _tarefas.Add(novaTarefa);
            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            //Buscando a minha lista tarefa que desejo alterar
            Tarefa tarefaDB = _tarefas.FirstOrDefault(t => t.Id == Id);
            //Verificando se encontrou a terefa para que possamos alterar
            if (tarefaDB == null)
                return NotFound();
            //Enviando para a View a tarefa encontrada que queremos buscar
            return View(tarefaDB);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefaEditando)
        {
            //Buscando tarefa da lista
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
            //Veridicando se encontrou ela
            if (tarefaDB == null)
                return NotFound();

            //Atualizando os dados da tarefa que já está na lista
            tarefaDB.Descricao = tarefaEditando.Descricao;
            tarefaDB.Concluida = tarefaDB.Concluida;
            //Redirecionando para a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int Id)
        {
            //Buscando a minha lista tarefa que desejo alterar
            Tarefa tarefaDB = _tarefas.FirstOrDefault(t => t.Id == Id);
            //Verificando se encontrou a terefa para que possamos alterar
            if (tarefaDB == null)
                return NotFound();
            return View(tarefaDB);
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaDB == null)
                return NotFound();

            _tarefas.Remove(tarefaDB);

            return RedirectToAction("Index");
        }
    }
} 