using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppGipTesting
{
    class Solution
    {
        public string problem { get; set; }
        public string solution { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }

        public Solution(string problem, string solution, string category, string subcategory)
        {
            this.problem = problem;
            this.solution = solution;
            this.category = category;
            this.subcategory = subcategory;
        }
        
    }
}
