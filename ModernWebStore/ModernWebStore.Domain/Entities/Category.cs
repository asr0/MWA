using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
  public  class Category
    {
        protected Category() { }
        public Category(string title)
        {
            this.Title = title;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
    }
}
