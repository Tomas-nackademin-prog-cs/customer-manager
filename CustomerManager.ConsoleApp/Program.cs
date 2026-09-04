using CustomerManager.ConsoleApp.Customers.Dialog;
using CustomerManager.ConsoleApp.Customers.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ICustomerService, InMemoryCustomerService>();
builder.Services.AddTransient<ICustomerDialog, CustomerDialog>();

using var host = builder.Build();

var dialog = host.Services.GetRequiredService<CustomerDialog>();

dialog.AddCustomerDialog();
dialog.ShowAllCustomers();