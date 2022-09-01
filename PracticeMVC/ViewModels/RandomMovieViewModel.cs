using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Type { get; set; }
        public List<Customer> Customers { get; internal set; }
    }
}