/*
' Copyright (c) 2016 dms.dk
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using Dms.Modules.DmsVis.Components;
using Newtonsoft.Json;

namespace Dms.Modules.DmsVis.Services.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemViewModel
    {
        public ItemViewModel(Item t, string detailUrl)
        {
            Id = t.ItemId;
            Name = t.ItemName;
            Url = t.ItemUrl;
            Description = t.ItemDescription;
            AssignedUser = t.AssignedUserId;
            DetailUrl = detailUrl;
        }

        public ItemViewModel(Item t, string detailUrl, string editUrl)
        {
            Id = t.ItemId;
            Name = t.ItemName;
            Url = t.ItemUrl;
            Description = t.ItemDescription;
            AssignedUser = t.AssignedUserId;
            DetailUrl = detailUrl;
            EditUrl = editUrl;
        }


        public ItemViewModel() { }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignedUser")]
        public int AssignedUser { get; set; }

        [JsonProperty("editUrl")]
        public string EditUrl { get; }

        [JsonProperty("detailUrl")]
        public string DetailUrl { get; }
    }
}