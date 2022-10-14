using ProiectMaster.Models.DTOs;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using System.Collections.Generic;

namespace ProiectMaster.Models.Interfaces
{
    public interface IOrderService
    {
        void SaveOrder(Order order, ProductVM[] products);
    }
}
