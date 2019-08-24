using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfm.Models;

namespace Xfm.Api
{
    public interface IMovieApi
    {
        [Get("/movie/upcoming?api_key={apiKey}")]
        Task<UpcomingResponse> GetUpcoming(string apiKey);
    }
}
