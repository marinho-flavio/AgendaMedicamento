using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.HealthPlans.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class PlanoConvenio : Entity
    {
        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
        public ClassificacaoServicoHospitalarEnum ClassificacaoServicoHospitalar { get; set; }

        //VERIFICAR TIPO PLANO SE EXISTEM MAIS OU SE É DE CADASTRO LIVRE DO USUÁRIO.
        public int TipoPlanoId { get; set; }
        public TipoPlano TipoPlano { get; set; }

        //VERIFICAR SE ESSES MULTIPLICADORES SÃO NÚMEROS, SE PODEM SER LETRAS PARA DEFINIR O TIPO.
        public decimal MultiplicadorHospitalar { get; set; }
        public decimal MultiplicadorProfissional { get; set; }
        public decimal MultiplicadorExame { get; set; }

        //VERIFICAR SE ESSES CAMPOS SÃO COM ESSE NOME OU SE PODE MELHORAR.

        public decimal ProcedimentoPercentualPrincipal { get; set; }
        public decimal ProcedimentoPrincipalDiferente { get; set; }
        public decimal ProcedimentoPrincipalMesma { get; set; }

        public decimal ProcedimentoHospitalarPrincipal { get; set; }
        public decimal ProcedimentoHospitalarDiferente { get; set; }
        public decimal ProcedimentoHospitalarMesma { get; set; }

        //

        public string DescricaoMedicamento { get; set; }
        public string MoedaMedicamento { get; set; }
        public TipoTabelaEnum TipoTabelaMedicamento { get; set; }
    }
}
