using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Annotation { get; set; }
        public string Text { get; set; }
        
        public int Category { get; set; }
    }
    public class EventDBContext : DbContext
    {
        public DbSet<Event> Movies { get; set; }
    }
}