using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfm.Models;

namespace Xfm.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
    }

    public sealed class ItemService : IItemService
    {
        public async Task<List<Item>> GetAll()
        {
            await Task.Delay(2000);

            return new List<Item>
            {
                Item.Create ("Eevee","normal", "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fblogs-images.forbes.com%2Fdavidthier%2Ffiles%2F2019%2F07%2F1200px-Ilima_Eevee-1200x675.jpg"),
                Item.Create ("Pikachu","elétrico","https://secure.img2-fg.wfcdn.com/im/02238154/compr-r85/8470/84707680/pokemon-pikachu-wall-decal.jpg"),
                Item.Create ("Dratini","dragão","https://i.pinimg.com/originals/75/e7/ac/75e7acfe055ef3dfb2b40d43a9d2fa1e.png"),
            };
        }
    }
}
