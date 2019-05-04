using Employees.Service;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employees.API.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("{document:int}")]
        public HttpResponseMessage Get(int document)
        {
            HttpResponseMessage response;
            try
            {
                EmployeeService employeeService = new EmployeeService();
                var employee = employeeService.GetEmployee(document);

                response = Request.CreateResponse(HttpStatusCode.OK, employee);
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
                throw;
            }

            return response;
        }

        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response;
            try
            {
                EmployeeService employeeService = new EmployeeService();
                List<DTO.Employee> employees = employeeService.GetEmployees();

                response = Request.CreateResponse(HttpStatusCode.OK, employees);
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
                throw;
            }

            return response;
        }
    }
}
