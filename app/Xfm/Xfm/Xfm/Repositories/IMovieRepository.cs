using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfm.Api;
using Xfm.Models;

namespace Xfm.Repositories
{
    public interface IMovieRepository
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }
}

 