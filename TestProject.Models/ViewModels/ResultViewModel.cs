using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Models.ViewModels
{
    public class ResultViewModel<T>
    { 
        public List<string> Errors { get; set; } = new List<string>();
        public T Body;
    }
}
