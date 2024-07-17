var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SkillsMatrixAPI>("skillsmatrixapi");

builder.Build().Run();
