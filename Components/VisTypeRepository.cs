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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Collections;
using DotNetNuke.Common;
using DotNetNuke.Data;
using DotNetNuke.Framework;

namespace Dms.Modules.DmsVis.Components
{
    public class VisTypeRepository : ServiceLocator<IVisTypeRepository, VisTypeRepository>, IVisTypeRepository
    {

        protected override Func<IVisTypeRepository> GetFactory()
        {
            return () => new VisTypeRepository();
        }


        /*public Item GetItem(int itemId, int moduleId)
        {
            Requires.NotNegative("itemId", itemId);
            Requires.NotNegative("moduleId", moduleId);

            Item t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }*/

        public IQueryable<VisType> GetVisTypes(int moduleId)
        {
            Requires.NotNegative("moduleId", moduleId);

            IQueryable<VisType> t = null;

            List<VisType> visTypes = new List<VisType>();
            visTypes.Add(new VisType() { VisTypeId = 0, VisTypeName = "Map" });
            visTypes.Add(new VisType() { VisTypeId = 2, VisTypeName = "Video" });
            visTypes.Add(new VisType() { VisTypeId = 3, VisTypeName = "Cow" });

            t = visTypes.AsQueryable();
            /*using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<VisType>();

                t = rep.Get(moduleId).AsQueryable();
            }*/

            return t;
        }

        /*public IPagedList<Item> GetItems(string searchTerm, int moduleId, int pageIndex, int pageSize)
        {
            Requires.NotNegative("moduleId", moduleId);

            var t = GetItems(moduleId).Where(c => c.ItemName.Contains(searchTerm)
                                                || c.ItemDescription.Contains(searchTerm));


            return new PagedList<Item>(t, pageIndex, pageSize);
        }*/
    }
}