using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Repositories;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.Specifications;
using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.CrossCuting.Infra.Utils.Extensions;
using CrossCuting.Infra.Utils.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.CommandHandlers
{
    public partial class GrupoEmpresaCommandHandler
    {
        partial void OnCreate(GrupoEmpresa entity)
        {
            SetAddress(entity).Wait();
        }

        partial void OnUpdate(GrupoEmpresa entity)
        {
            SetAddress(entity).Wait();
        }

        private async Task SetAddress(GrupoEmpresa entity)
        {
            var addressRepo = _serviceProvider.GetRequiredService<IEnderecoRepository>();
            var end = entity.GrupoEmpresaEndereco?.Endereco;
            var address = await addressRepo.FindAsync(EnderecoSpecifications.CEPEqual(end?.CEP).SatisfiedBy());
            if (address?.CEP is not null)
            {
                entity.GrupoEmpresaEndereco.Endereco = address;
                //if (end.HasChanged(address))
                //{
                //    end = entity.GrupoEmpresaEndereco.Endereco = new Endereco();
                //    end = end.Copy(namesToIgnore: new string[] { nameof(end.Id), nameof(end.ExternalId) });
                //    end.ExternalId = Guid.NewGuid().ToString();
                //}
            }
            else if (entity?.GrupoEmpresaEndereco?.EnderecoId.HasValue != true)
            {
                if (entity.GrupoEmpresaEndereco != null)
                {
                    entity.GrupoEmpresaEndereco.Endereco = null;
                }
            }
        }
    }

    public partial class EmpresaCommandHandler
    {
        partial void OnCreate(Empresa entity)
        {
            SetAddress(entity).Wait();
        }

        partial void OnUpdate(Empresa entity)
        {
            SetAddress(entity).Wait();
        }

        private async Task SetAddress(Empresa entity)
        {
            var addressRepo = _serviceProvider.GetRequiredService<IEnderecoRepository>();
            var end = entity.Endereco?.Endereco;
            var address = await addressRepo.FindAsync(EnderecoSpecifications.CEPEqual(end?.CEP).SatisfiedBy());
            if (address?.CEP is not null)
            {
                entity.Endereco.Endereco = address;
                //if (end.HasChanged(address))
                //{
                //    end = entity.EmpresaEndereco.Endereco = new Endereco();
                //    end = end.Copy(namesToIgnore: new string[] { nameof(end.Id), nameof(end.ExternalId) });
                //    end.ExternalId = Guid.NewGuid().ToString();
                //}
            }
            else if (entity?.Endereco?.EnderecoId.HasValue != true)
            {
                if (entity.Endereco != null)
                {
                    entity.Endereco.Endereco = null;
                }
            }
        }
    }
}
