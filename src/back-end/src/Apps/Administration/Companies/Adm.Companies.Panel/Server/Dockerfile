#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Apps/Administration/Companies/Adm.Companies.Panel/Server/Companies.Adm.Panel.Server.csproj", "src/Apps/Administration/Companies/Adm.Companies.Panel/Server/"]
COPY ["src/Addresses/Addresses.Infra.IoC/Addresses.Infra.IoC.csproj", "src/Addresses/Addresses.Infra.IoC/"]
COPY ["src/Core/Core.Infra.IoC/Core.Infra.IoC.csproj", "src/Core/Core.Infra.IoC/"]
COPY ["src/Addresses/Addresses.Application/Addresses.Application.csproj", "src/Addresses/Addresses.Application/"]
COPY ["src/Companies/Companies.Domain/Companies.Domain.csproj", "src/Companies/Companies.Domain/"]
COPY ["Professionals.CrossCutting.Domain/Professionals.CrossCutting.Domain.csproj", "Professionals.CrossCutting.Domain/"]
COPY ["src/Core/Core.Application.DTO/Core.Application.DTO.csproj", "src/Core/Core.Application.DTO/"]
COPY ["src/Companies/Companies.Enumerations/Companies.Enumerations.csproj", "src/Companies/Companies.Enumerations/"]
COPY ["src/CrossCutting/CrossCutting.Utils/CrossCuting.Infra.Utils.csproj", "src/CrossCutting/CrossCutting.Utils/"]
COPY ["src/Professionals/Professionals.Enumerations/Professionals.Enumerations.csproj", "src/Professionals/Professionals.Enumerations/"]
COPY ["src/Schedulings/Schedulings.Enumerations/Schedulings.Enumerations.csproj", "src/Schedulings/Schedulings.Enumerations/"]
COPY ["src/Core/Core.Domain/Core.Domain.csproj", "src/Core/Core.Domain/"]
COPY ["src/CrossCutting/CrossCutting.Infra.Log/CrossCutting.Infra.Log.csproj", "src/CrossCutting/CrossCutting.Infra.Log/"]
COPY ["src/Companies/Companies.Application.DTO/Companies.Application.DTO.csproj", "src/Companies/Companies.Application.DTO/"]
COPY ["src/Companies/Companies.CrossCutting.Domain/Companies.CrossCutting.Domain.csproj", "src/Companies/Companies.CrossCutting.Domain/"]
COPY ["src/Core/Core.Application/Core.Application.csproj", "src/Core/Core.Application/"]
COPY ["src/Addresses/Addresses.Infra.Data/Addresses.Infra.Data.csproj", "src/Addresses/Addresses.Infra.Data/"]
COPY ["src/Core/Core.Infra.Core.Data/Core.Infra.Data.csproj", "src/Core/Core.Infra.Core.Data/"]
COPY ["src/Addresses/Addresses.Domain/Addresses.Domain.csproj", "src/Addresses/Addresses.Domain/"]
COPY ["src/Addresses/Addresses.Application.DTO/Addresses.Application.DTO.csproj", "src/Addresses/Addresses.Application.DTO/"]
COPY ["src/ClinicalProcedures/ClinicalProcedures.Infra.IoC/ClinicalProcedures.Infra.IoC.csproj", "src/ClinicalProcedures/ClinicalProcedures.Infra.IoC/"]
COPY ["src/ClinicalProcedures/ClinicalProcedures.Infra.Data/ClinicalProcedures.Infra.Data.csproj", "src/ClinicalProcedures/ClinicalProcedures.Infra.Data/"]
COPY ["src/ClinicalProcedures/ClinicalProcedures.Domain/ClinicalProcedures.Domain.csproj", "src/ClinicalProcedures/ClinicalProcedures.Domain/"]
COPY ["src/ClinicalProcedures/ClinicalProcedures.Application.DTO/ClinicalProcedures.Application.DTO.csproj", "src/ClinicalProcedures/ClinicalProcedures.Application.DTO/"]
COPY ["src/ClinicalProcedures/ClinicalProcedures.Enumerations/ClinicalProcedures.Enumerations.csproj", "src/ClinicalProcedures/ClinicalProcedures.Enumerations/"]
COPY ["src/HealthPlans/HealthPlans.Infra.IoC/HealthPlans.Infra.IoC.csproj", "src/HealthPlans/HealthPlans.Infra.IoC/"]
COPY ["src/HealthPlans/HealthPlans.Application/HealthPlans.Application.csproj", "src/HealthPlans/HealthPlans.Application/"]
COPY ["src/HealthPlans/HealthPlans.Application.DTO/HealthPlans.Application.DTO.csproj", "src/HealthPlans/HealthPlans.Application.DTO/"]
COPY ["src/HealthPlans/HealthPlans.Domain/HealthPlans.Domain.csproj", "src/HealthPlans/HealthPlans.Domain/"]
COPY ["src/HealthPlans/HealthPlans.Enumerations/HealthPlans.Enumerations.csproj", "src/HealthPlans/HealthPlans.Enumerations/"]
COPY ["src/HealthPlans/HealthPlans.Infra.Data/HealthPlans.Infra.Data.csproj", "src/HealthPlans/HealthPlans.Infra.Data/"]
COPY ["src/Partners/Partners.Infra.IoC/Partners.Infra.IoC.csproj", "src/Partners/Partners.Infra.IoC/"]
COPY ["src/Partners/Partners.Application/Partners.Application.csproj", "src/Partners/Partners.Application/"]
COPY ["src/Partners/Partners.Application.DTO/Partners.Application.DTO.csproj", "src/Partners/Partners.Application.DTO/"]
COPY ["src/Partners/Partners.Domain/Partners.Domain.csproj", "src/Partners/Partners.Domain/"]
COPY ["src/Partners/Partners.Enumerations/Partners.Enumerations.csproj", "src/Partners/Partners.Enumerations/"]
COPY ["src/Partners/Partners.Infra.Data/Partners.Infra.Data.csproj", "src/Partners/Partners.Infra.Data/"]
COPY ["src/Companies/Companies.Infra.IoC/Companies.Infra.IoC.csproj", "src/Companies/Companies.Infra.IoC/"]
COPY ["src/Companies/Companies.Application/Companies.Application.csproj", "src/Companies/Companies.Application/"]
COPY ["src/Companies/Companies.Infra.Data/Companies.Infra.Data.csproj", "src/Companies/Companies.Infra.Data/"]
COPY ["src/Patients/Patients.Infra.IoC/Patients.Infra.IoC.csproj", "src/Patients/Patients.Infra.IoC/"]
COPY ["src/Patients/Patients.Application/Patients.Application.csproj", "src/Patients/Patients.Application/"]
COPY ["src/Patients/Patients.Application.DTO/Patients.Application.DTO.csproj", "src/Patients/Patients.Application.DTO/"]
COPY ["src/Patients/Patients.Enumerations/Patients.Enumerations.csproj", "src/Patients/Patients.Enumerations/"]
COPY ["src/Patients/Patients.Domain/Patients.Domain.csproj", "src/Patients/Patients.Domain/"]
COPY ["src/Patients/Patients.Infra.Data/Patients.Infra.Data.csproj", "src/Patients/Patients.Infra.Data/"]
COPY ["src/Professionals/Professionals.Infra.IoC/Professionals.Infra.IoC.csproj", "src/Professionals/Professionals.Infra.IoC/"]
COPY ["src/Professionals/Professionals.Application/Professionals.Application.csproj", "src/Professionals/Professionals.Application/"]
COPY ["src/Professionals/Professionals.Application.DTO/Professionals.Application.DTO.csproj", "src/Professionals/Professionals.Application.DTO/"]
COPY ["src/Professionals/Professionals.Domain/Professionals.Domain.csproj", "src/Professionals/Professionals.Domain/"]
COPY ["src/Professionals/Professionals.Infra.Data/Professionals.Infra.Data.csproj", "src/Professionals/Professionals.Infra.Data/"]
COPY ["src/Schedulings/Schedulings.Infra.IoC/Schedulings.Infra.IoC.csproj", "src/Schedulings/Schedulings.Infra.IoC/"]
COPY ["src/Schedulings/Schedulings.Application/Schedulings.Application.csproj", "src/Schedulings/Schedulings.Application/"]
COPY ["src/Schedulings/Schedulings.Application.DTO/Schedulings.Application.DTO.csproj", "src/Schedulings/Schedulings.Application.DTO/"]
COPY ["src/Schedulings/Schedulings.Domain/Schedulings.Domain.csproj", "src/Schedulings/Schedulings.Domain/"]
COPY ["src/Schedulings/Schedulings.Infra.Data/Schedulings.Infra.Data.csproj", "src/Schedulings/Schedulings.Infra.Data/"]
COPY ["src/Users.Identity/Users.Identity.csproj", "src/Users.Identity/"]
COPY ["src/Users/Users.Application/Users.Application.csproj", "src/Users/Users.Application/"]
COPY ["src/Users/Users.Data/Users.Infra.Data.csproj", "src/Users/Users.Data/"]
COPY ["src/Users/Users.Domain/Users.Domain.csproj", "src/Users/Users.Domain/"]
COPY ["src/Users/UsersApplication.DTO/Users.Application.DTO.csproj", "src/Users/UsersApplication.DTO/"]
COPY ["src/Users/Users.Infra.IoC/Users.Infra.IoC.csproj", "src/Users/Users.Infra.IoC/"]
COPY ["src/Apps/Administration/Companies/Adm.Companies.Panel/Client/Companies.Adm.Panel.Client.csproj", "src/Apps/Administration/Companies/Adm.Companies.Panel/Client/"]
COPY ["src/Core.App.Client/Core.App.Client.csproj", "src/Core.App.Client/"]
COPY ["src/Apps/Administration/Companies/Adm.Companies.Panel/Shared/Companies.Adm.Panel.Shared.csproj", "src/Apps/Administration/Companies/Adm.Companies.Panel/Shared/"]
COPY ["src/Addresses/Addresses.Enumerations/Addresses.Enumerations.csproj", "src/Addresses/Addresses.Enumerations/"]
RUN dotnet restore "src/Apps/Administration/Companies/Adm.Companies.Panel/Server/Companies.Adm.Panel.Server.csproj"
COPY . .
WORKDIR "/src/src/Apps/Administration/Companies/Adm.Companies.Panel/Server"
RUN dotnet build "Companies.Adm.Panel.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Companies.Adm.Panel.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Companies.Adm.Panel.Server.dll"]