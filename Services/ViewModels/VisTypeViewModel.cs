using DotNetNuke.Entities.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dms.Modules.DmsVis.Components;

namespace Dms.Modules.DmsVis.Services.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class VisTypeViewModel
    {
        public VisTypeViewModel(VisType t)
        {
            Id = t.VisTypeId;
            Name = t.VisTypeName;
        }

        public VisTypeViewModel() { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}