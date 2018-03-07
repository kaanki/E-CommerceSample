using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Common;

namespace ECommerce.Repository
{
    public class CommentRep:DataRepository<Comments,int>
    {
        MyECommerceDBEntities db = Tools.GetConection();

        public override Result<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Result<List<Comments>> GetLatestObj(int Quantity)
        {
            throw new NotImplementedException();
        }

        public override Result<Comments> GetObjById(int id)
        {
            comment
        }

        public override Result<int> Insert(Comments item)
        {
            throw new NotImplementedException();
        }

        public override Result<List<Comments>> List()
        {
            throw new NotImplementedException();
        }

        public override Result<int> Update(Comments item)
        {
            throw new NotImplementedException();
        }
    }
}
