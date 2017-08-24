using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureBeyondBasics.Controllers
{
    public class StorageController : Controller
    {
        // GET: Storage
        public ActionResult Index()
        {
            return View();
        }
    }

    public class CustomerEntity : TableEntity
    {
        public CustomerEntity(Guid employeeId)
        {
            PartitionKey = "customer";
            RowKey = employeeId.ToString();
        }

        public CustomerEntity() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}