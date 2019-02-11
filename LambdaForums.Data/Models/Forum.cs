using System;
using System.Collections.Generic;

namespace LambdaForums.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }


        // Virtual property will allow us to lazy load the property in EntityFramework
        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
