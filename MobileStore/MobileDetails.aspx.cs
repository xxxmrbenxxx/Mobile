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
    public partial class MobileDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }
        public IQueryable<Mobile> GetDetails([QueryString("mobileID")] int? bookId)
        {
            var _db = new MobileStore.Models.MobileContext();
            IQueryable<Mobile> query = _db.Mobiles;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.MoblieID == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}