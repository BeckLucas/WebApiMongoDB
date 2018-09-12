using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotebookAppApi.Repository;

namespace NotebookAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _noteRepository;

        //public NotesController(INoteRepository noteRepository)
        //{
        //    _noteRepository = noteRepository;
        //}

    }
}