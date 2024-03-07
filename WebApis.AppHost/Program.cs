var builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.WebApis_Academico>("webapis.academico");
builder.AddProject<Projects.WebApis_Financeiro>("webapis.financeiro");
builder.AddProject<Projects.WebApis_Vestibular>("webapis.vestibular");

builder.AddProject<Projects.WebApis_Gateway>("webapis.gateway");

builder.Build().Run();
