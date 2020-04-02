﻿using System;
using System.Collections.Generic;
using System.Text;
using MBshopService.OutputModels;

namespace MBshopService.interfaces
{
    public interface ICartService
    {
        List<ViewProducts> GetCartBascket();
        string AddToCartBook(int id, double price);
        string AddToCartMovie(int id, double price);
        void DisposeCartProducts();
        void RemoveMovie(int id);
        void RemoveBook(int id);
    }
}