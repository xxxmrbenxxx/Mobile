using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileStore.Models;

namespace MobileStore
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Product> GetCategories()
        {
            var _db = new MobileStore.Models.MobileContext();
            IQueryable<Product> query = _db.Products;
            return query;
        }
    }
}