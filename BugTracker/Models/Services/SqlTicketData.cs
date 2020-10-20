using BugTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models.Services
{
    public class SqlTicketData : ITicketData
    {
        private readonly AuthDbContext db;

        public SqlTicketData(AuthDbContext db)
        {
            this.db = db;
        }
        public void Add(Ticket ticket)
        {
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ticket = db.Tickets.Find(id);
            db.Tickets.Remove(ticket);
            db.SaveChanges();
        }

        public Ticket Get(int id)
        {
            var ticket = db.Tickets.FirstOrDefault(t => t.Id == id);
            return ticket;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return db.Tickets;
        }

        public void Update(Ticket ticket)
        {
            var entry = db.Entry(ticket);
            entry.State = EntityState.Modified;
            db.Entry(ticket).Property(u => u.ProjectId).IsModified = false;
            db.SaveChanges();
        }
    }
}
