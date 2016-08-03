using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dms.Modules.DmsVis.Services.ViewModels;
using DotNetNuke.Web.Api;
using DotNetNuke.Security;
using Dms.Modules.DmsVis.Components;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using System.Net.Http;

namespace Dms.Modules.DmsVis.Services
{
    [SupportedModules("DmsVis")]
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
    public class VisTypeController: DnnApiController
    {
        private readonly IVisTypeRepository _repository;

        public VisTypeController(IVisTypeRepository repository)
        {
            Requires.NotNull(repository);

            this._repository = repository;
        }

        public VisTypeController() : this(VisTypeRepository.Instance) { }
        public HttpResponseMessage GetList()
        {
            List<VisTypeViewModel> visTypes;
            visTypes = _repository.GetVisTypes(ActiveModule.ModuleID)
                .Select(visType => new VisTypeViewModel(visType)).ToList();
            return Request.CreateResponse(visTypes);
        }
    }
}