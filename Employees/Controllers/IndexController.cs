using Employees.DTO;
using Employees.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SumaCubos.Controllers
{
    public class IndexController : Controller
    {
        private readonly string _UrlSchema = ConfigurationManager.AppSettings["ApiUrl"];
        const string UrlSchemaPath = "/api/Employee";

        public ActionResult Index()
        {
            EmployeeModel model = new EmployeeModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(EmployeeModel model)
        {
            if (model.Document != 0)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = client.GetAsync(_UrlSchema + UrlSchemaPath + "/" + model.Document).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = JsonConvert.DeserializeObject<Employee>(response.Content.ReadAsStringAsync().Result);
                            if(result != null)
                            {
                                model.Employees.Add(result);
                            }

                            var data = new { employees = model.Employees };
                            return Json(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = client.GetAsync(_UrlSchema + UrlSchemaPath).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            Task<string> result = client.GetStringAsync(_UrlSchema + UrlSchemaPath);
                            var employees = Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Employee>>(result.Result)).Result;
                            if (employees != null)
                            {
                                model.Employees.AddRange(employees);
                            }

                            var data = new { employees = model.Employees };
                            return Json(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            
            return View(model);
        }
    }
}