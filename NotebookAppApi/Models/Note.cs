﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Models
{
    public class Note
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }

        // external Id, easier to reference: 1,2,3 or A, B, C etc.
        public string Id { get; set; }

        public string Body { get; set; } = string.Empty;

        [BsonDateTimeOptions]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        public NoteImage HeaderImage { get; set; }

        public int UserId { get; set; } = 0;
    }

    public class NoteImage
    {
        public string Url { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public long ImageSize { get; set; } = 0L;
    }
}