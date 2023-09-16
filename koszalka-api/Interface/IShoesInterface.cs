﻿using koszalka_api.DTO;
using koszalka_api.Model;
using Microsoft.AspNetCore.Mvc;

namespace koszalka_api.Interface
{
    public interface IShoesInterface
    {
        Task<ActionResult<IEnumerable<Shoes>>> GetShoes();
        Task<Shoes> GetShoe(long id);
        Task<Boolean> PutShoe(long id, Shoes shoes);
        Task<int> PostShoe(Shoes shoes);
        Task<int> DeleteShoe(long id);
    }
}