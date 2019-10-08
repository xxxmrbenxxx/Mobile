using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStore.Models;
using System.Web.ModelBinding;
namespace MobileStore
{
    public partial class MobileList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Mobile> GetMobile([QueryString("id")] int? categoryId)
        {
            var _db = new MobileStore.Models.MobileContext();
            IQueryable<Mobile> query = _db.Mobiles;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.ProductID == categoryId);
            }
            return query;
        }
    }
}