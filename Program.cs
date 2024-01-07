using MudBlazor.Services;
using PatientsMedicines.Components;
using PatientsMedicines.DataLayer;
using PatientsMedicines.UseCases.CreatePatientMedicineGroup;
using PatientsMedicines.UseCases.GetMedicineGroups;
using PatientsMedicines.UseCases.GetPatientMedicineGroups;
using PatientsMedicines.UseCases.GetPatients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddDbContext<MedicineResearchDbContext>();
builder.Services.AddTransient<IGetPatientMedicineGroups, GetPatientMedicineGroupsUseCase>();
builder.Services.AddTransient<IGetPatients, GetPatientsUseCase>();
builder.Services.AddTransient<IGetMedicineGroups, GetMedicineGroupsUseCase>();
builder.Services.AddTransient<ICreatePatientMedicineGroup, CreatePatientMedicineGroupUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
