using NotebookAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Repository
{
    interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllNotes();

        Task<Note> GetNote(string id);

        Task<IEnumerable<Note>> GetNote(string bodyText, DateTime updatedFrom, long headerSizeLimit);

        Task AddNote(Note item);

        Task<bool> RemoveNote(string id);

        Task<bool> UpdateNote(string id, string body);

        Task<bool> UpdateNoteDocument(string id, string body);

        Task<bool> RemoveAllNotes();
    }
}
