using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Autofac;
using EfTUtorial.Autofac;
using EfTUtorial.Database.Contracts;
using EfTUtorial.Database.Entities;

namespace EfTUtorial
{
    class Program
    {
        static void Main(string[] args)
        {
            AutofacConfiguration.RegisterContainer();
            IDatabaseContext context = AutofacConfiguration.Container.Resolve<IDatabaseContext>();

            using (context)
            {
                var noteEntity = new Note
                {
                    Author = "Doru",
                    Message = "Tenant message",
                    Timestamp = DateTime.UtcNow,
                    Adendums = new List<Adendum>()
                };

                noteEntity.Adendums.Add(new Adendum
                {
                    Note = noteEntity,
                    AdendumContent = "some adendum content",
                    NoteId = noteEntity.Id,
                });

                noteEntity.Adendums.Add(new Adendum
                {
                    Note = noteEntity,
                    AdendumContent = "yet another adendum content",
                    NoteId = noteEntity.Id,
                });

                context.Notes.Add(noteEntity);

                context.SaveChanges();


                var notes = context.Notes.Include(x => x.Adendums).ToList();

                foreach (var note in notes)
                {
                    Console.WriteLine("Note : {0} with message {1} with {2} adendums", note.Id, note.Message, note.Adendums.Count);
                }

                Console.WriteLine("Total of {0} notes", notes.Count);

                Console.ReadKey();
            }
        }
    }
}
