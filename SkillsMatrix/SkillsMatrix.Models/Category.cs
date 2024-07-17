using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class Category
    {
        public int? Id { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Description of the Category
        /// </summary>
        public string? Description { get; set; }

        public Category? Parent { get; set; }

        public bool IsActive { get; set; }

    }
}
