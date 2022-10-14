using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster.Web.Controllers
{
    [Route("[Controller]")]
    public class OrderController : Controller
    {
        private readonly IProductService productService;
        private readonly IOrderService orderService;

        public OrderController(IProductService productService, IOrderService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);
            if (shopList == null)
            {
                return RedirectToAction("Index", "Home", productService.GetAllProducts());
            }
            var orderProducts = this.productService.GetOrderProducts(shopList.ToArray());

            mymodel.OrderDetails = orderProducts.ToArray();
            mymodel.OrderHeader = new Order();

            return View(mymodel);
        }

        [HttpPost]
        [Route("New")]
        public IActionResult New(Order orderHeader)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors in your form");
                return View(orderHeader);
            }

            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);
            var orderDetails = this.productService.GetOrderProducts(shopList.ToArray());

            this.orderService.SaveOrder(orderHeader, orderDetails.ToArray());

            SendEmail(orderHeader, orderDetails.ToArray()).Wait();

            HttpContext.Session.Set(SessionHelper.ShoppingCart, new List<int>());
            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }
        static async Task SendEmail(Order orderHeader, ProductVM[] orderDetails)
        {
            var key = "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";
            var client = new SendGridClient(key);
            var from_email = new EmailAddress("cojo.andreea@gmail.com", "MagazinVirtual");//"MagazinVirtual@gmail.com"
            var subject = "Detalii comanda MagazinVirtual";
            var to_email = new EmailAddress(orderHeader.CustomerEmail, orderHeader.CustomerName);
            var plainTextContent = "";
            var htmlContent = "<h1>Comanda de pe data " + orderHeader.OrderDate + " a fost trimisa cu success</h1>";
            htmlContent += "<h2>Produse comandate</h2>";
            htmlContent += "<table id=\"table\" class=\"table table-hover table-striped table-dark\"><thead><tr><th hidden>Product Id</th><th>Image</th><th>Product name</th><th>Price</th></tr></thead><tbody>";
            var fullPath = @"D:\facultate\ecommerce\ProiectMaster\ProiectMaster.Web\wwwroot\";
            foreach (var item in orderDetails)
            {
                var imageArray = System.IO.File.ReadAllBytes(fullPath + item.ImagePath);
                var base64ImageRepresentation = Convert.ToBase64String(imageArray);

                htmlContent += "" +
                    "<tr id =\"" + item.Id + "\">" +
                        "<td hidden>" + item.Id + "</td>" +
                        "<td><img style=\"width: 300px; height: 150px;\" src=\"data:image/jpeg;base64," + base64ImageRepresentation + "\" alt=\"nu exista imagine momentan\" /></td>" +
                        "<td>" + item.Name + "</td>" +
                        "<td>" + item.Price + "</td>" +
                     "</tr>";

                //htmlContent += "<img alt = \"My Image\" src = \"data:image/jpeg;base64,"+ base64ImageRepresentation + "\"/>";
            }
            htmlContent += "</tbody></table>";
            htmlContent += "<h2>Adresa de livrare: " + orderHeader.CustomerAddress + "</h2>";

            var msg = MailHelper.CreateSingleEmail(from_email, to_email, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);

        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public JsonResult Delete(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);

            if (shopList == null)
                return Json(new { success = false, message = "shopList is null" });

            if (shopList.Contains(id))
                shopList.Remove(id);

            HttpContext.Session.Set(SessionHelper.ShoppingCart, shopList);

            return Json(new { success = true, message = "Product succesfully removed from order" });
        }
    }
}
