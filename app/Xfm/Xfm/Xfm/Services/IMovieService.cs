using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfm.Models;
using Xfm.Repositories;

namespace Xfm.Services
{
    public interface IMovieService
    {
        Task<(string erro, List<Movie>)> GetUpcoming();
    }

    public sealed class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;
        public MovieService()
        {
            movieRepository = new MovieRepository();
        }

        public Task<(string erro, List<Movie>)> GetUpcoming()
            => movieRepository.GetUpcoming();
    }


}
