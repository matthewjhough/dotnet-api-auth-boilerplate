using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mgm_app.Models {
    public class Example {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Example> Examples { get; set; }
    }
}