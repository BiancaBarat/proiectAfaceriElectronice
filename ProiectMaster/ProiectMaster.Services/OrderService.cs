using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ProiectMaster.DataAccess.Interfaces;
using ProiectMaster.Models.DTOs;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProiectMaster.Services
{
    public class OrderService : IOrderService
    {
        private OrderDataAccess dataAccess; 

        public OrderService(IConfiguration configuration)
        {
            this.dataAccess = new OrderDataAccess(configuration);
        }

        public void SaveOrder(Order order, ProductVM[] products)
        {
            this.dataAccess.SaveOrder(order, products);
        }
        
    }
}
