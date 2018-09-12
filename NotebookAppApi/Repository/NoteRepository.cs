using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using NotebookAppApi.Models;

namespace NotebookAppApi.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteContext _context = null;

        public NoteRepository(IOptions<Settings> settings)
        {
            _context = new NoteContext(settings);
        }

        public async Task AddNote(Note item)
        {
            try
            {
                await _context.Notes.InsertOneAsync(item);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            try
            {
                return await _context.Notes.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Note> GetNote(string id)
        {
            try
            {
                ObjectId internalId = GetInternalId(id);
                return await _context.Notes.Find(note => note.Id == id || note.InternalId == internalId).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ObjectId GetInternalId(string id)
        {
            ObjectId internalId;
            if (!ObjectId.TryParse(id, out internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }

        public Task<IEnumerable<Note>> GetNote(string bodyText, DateTime updatedFrom, long headerSizeLimit)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAllNotes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveNote(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNote(string id, string body)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNoteDocument(string id, string body)
        {
            throw new NotImplementedException();
        }
    }
}
